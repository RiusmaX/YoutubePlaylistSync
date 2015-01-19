using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;


namespace YoutubePlaylistSync
{
    
    public partial class MainForm : Form
    {
        internal delegate void ThreadProcSafeDelegate(double progress);
        internal static event ThreadProcSafeDelegate ThreadProcSafe;

        public MainForm()
        {
            InitializeComponent();
            YoutubeGetter.UpdateProgress += UpdateProgress;
            YoutubeGetter.UpdateListBox += UpdateListBox;
            YoutubePlaylistGetter.UpdateListBox += UpdateListBox;
            YoutubePlaylistGetter.UpdateListBox1 += UpdateListBox1;
            SoundCloudGetter.UpdateListBox += UpdateListBox1;

            comboBox_audioFormats.Items.Add("MP3");
            comboBox_audioFormats.Items.Add("WAV");     
            comboBox_audioFormats.SelectedIndex = 0;
                 

            comboBox_videoFormats.Items.Add("MP4");
            comboBox_videoFormats.Items.Add("3GP");
            comboBox_videoFormats.Items.Add("Flash");
            comboBox_videoFormats.Items.Add("WebM");
            comboBox_videoFormats.SelectedIndex = 0;

           
            textBox_link_soundCloudSingleLink.Text = "https://soundcloud.com/edm/party-thieves-atliens-chief-edmcom-exclusive";
            textBox_folder.Text = @"C:\Users\Marius\Desktop\";
            textbox_link.Text = "https://www.youtube.com/watch?v=b2Oyh15I1CU";
            checkBox_audio.Checked = true;
        }

       

        private void UpdateProgress(double progress)
        {
            progressBar1.Value = Convert.ToInt32(progress);
        }

        private void UpdateListBox(string txt)
        {
            listBox2.Items.Add(txt);
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }

        private void UpdateListBox1(string txt)
        {
            listBox1.Items.Add(txt);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void button_paste_Click(object sender, EventArgs e)
        {
            IEnumerable<VideoInfo> listeInfos = null;
            String link = Clipboard.GetText();
            textbox_link.Text = link;
            try
            {
                listeInfos = YoutubeGetter.getVideoInformations(link).Distinct();
            }
            catch (Exception)
            {
                UpdateListBox("Le lien Youtube n'est pas valide");
                return;
            }           
        }       


        private void button_folder_Click(object sender, EventArgs e)
        {            
            folderBrowserDialog1.Description = "Choisissez le répertoire";
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != String.Empty)
	            textBox_folder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (checkBox_audio.Checked || checkBox_video.Checked)
            {
                if (checkBox_audio.Checked)
                {
                    string link = "";
                    if (textbox_link.Text.Length > 0)
                    {                
                        int resolution = 144;
                        int bitrate = 320;
                        link = textbox_link.Text;
                        IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false);
                        YoutubeGetter.getAudio(videoInfos, textBox_folder.Text);
                        //,VideoType.Mp4,comboBox_audioFormats.SelectedText,resolution,bitrate
                    }                         
                    
                }

                if (checkBox_video.Checked)
                {
                    string link = "";
                    if (textBox_folder.Text.Length > 0)
                    {
                        link = textbox_link.Text;
                        IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false);
                        YoutubeGetter.getAudio(videoInfos, textBox_folder.Text);                        
                    }
                }         
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            UpdateListBox("Effectue en : " + elapsedTime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Choisissez le répertoire";
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != String.Empty)
                textBox_folder_playlist.Text = folderBrowserDialog1.SelectedPath+"\\";
        }

        private void button_paste_playlist_Click(object sender, EventArgs e)
        {      
            String link = Clipboard.GetText();
            textBox_paste_playlist.Text = link;            
        }

        private void button_get_playlist_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            YoutubePlaylistGetter YPG = new YoutubePlaylistGetter();
            YPG.getPlaylist(textBox_paste_playlist.Text,textBox_folder_playlist.Text);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            UpdateListBox("Effectue en : " + elapsedTime);
        }

        private void button_paste_SoundCloudSingleLink_Click(object sender, EventArgs e)
        {
            String link = Clipboard.GetText();
            textBox_link_soundCloudSingleLink.Text = link;            
        }

        private void button_folder_SoundCloudSingleLink_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Choisissez le répertoire";
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != String.Empty)
                textBox_folder_soundCloudSingleLink.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        private void button_get_SoundCloudSingleLink_Click(object sender, EventArgs e)
        {
            SoundCloudGetter scg = new SoundCloudGetter();
            scg.getSoundCloudSound(textBox_link_soundCloudSingleLink.Text,textBox_folder_soundCloudSingleLink.Text);
        }

        

    }
}
