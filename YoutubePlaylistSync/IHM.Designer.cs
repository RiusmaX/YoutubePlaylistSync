namespace YoutubePlaylistSync
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Youtube = new System.Windows.Forms.TabControl();
            this.YoutubeSingleLinkDownloader = new System.Windows.Forms.TabPage();
            this.button_get = new System.Windows.Forms.Button();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.comboBox_videoFormats = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_video = new System.Windows.Forms.CheckBox();
            this.checkBox_audio = new System.Windows.Forms.CheckBox();
            this.comboBox_audioFormats = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_paste = new System.Windows.Forms.Button();
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.textbox_link = new System.Windows.Forms.TextBox();
            this.button_folder = new System.Windows.Forms.Button();
            this.YoutubePlaylistDownloader = new System.Windows.Forms.TabPage();
            this.button_get_playlist = new System.Windows.Forms.Button();
            this.button_paste_playlist = new System.Windows.Forms.Button();
            this.button_folder_playlist = new System.Windows.Forms.Button();
            this.textBox_folder_playlist = new System.Windows.Forms.TextBox();
            this.textBox_paste_playlist = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SoundCloudSingleLinkDownloader = new System.Windows.Forms.TabPage();
            this.button_get_SoundCloudSingleLink = new System.Windows.Forms.Button();
            this.button_paste_SoundCloudSingleLink = new System.Windows.Forms.Button();
            this.button_folder_SoundCloudSingleLink = new System.Windows.Forms.Button();
            this.textBox_folder_soundCloudSingleLink = new System.Windows.Forms.TextBox();
            this.textBox_link_soundCloudSingleLink = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_resolution = new System.Windows.Forms.Label();
            this.label_bitrate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.trackBar_qualité = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl_Youtube.SuspendLayout();
            this.YoutubeSingleLinkDownloader.SuspendLayout();
            this.groupBox_options.SuspendLayout();
            this.YoutubePlaylistDownloader.SuspendLayout();
            this.SoundCloudSingleLinkDownloader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_qualité)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Youtube
            // 
            this.tabControl_Youtube.Controls.Add(this.YoutubeSingleLinkDownloader);
            this.tabControl_Youtube.Controls.Add(this.YoutubePlaylistDownloader);
            this.tabControl_Youtube.Controls.Add(this.SoundCloudSingleLinkDownloader);
            this.tabControl_Youtube.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Youtube.Name = "tabControl_Youtube";
            this.tabControl_Youtube.SelectedIndex = 0;
            this.tabControl_Youtube.Size = new System.Drawing.Size(553, 304);
            this.tabControl_Youtube.TabIndex = 0;
            // 
            // YoutubeSingleLinkDownloader
            // 
            this.YoutubeSingleLinkDownloader.Controls.Add(this.label8);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.label7);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.label6);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.trackBar_qualité);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.groupBox_options);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.groupBox1);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.button_paste);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.textBox_folder);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.textbox_link);
            this.YoutubeSingleLinkDownloader.Controls.Add(this.button_folder);
            this.YoutubeSingleLinkDownloader.Location = new System.Drawing.Point(4, 22);
            this.YoutubeSingleLinkDownloader.Name = "YoutubeSingleLinkDownloader";
            this.YoutubeSingleLinkDownloader.Padding = new System.Windows.Forms.Padding(3);
            this.YoutubeSingleLinkDownloader.Size = new System.Drawing.Size(545, 278);
            this.YoutubeSingleLinkDownloader.TabIndex = 0;
            this.YoutubeSingleLinkDownloader.Text = "Single Downloader";
            this.YoutubeSingleLinkDownloader.UseVisualStyleBackColor = true;
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(559, 312);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(452, 147);
            this.button_get.TabIndex = 16;
            this.button_get.Text = "Télécharger";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // groupBox_options
            // 
            this.groupBox_options.Controls.Add(this.comboBox_videoFormats);
            this.groupBox_options.Controls.Add(this.label4);
            this.groupBox_options.Controls.Add(this.checkBox_video);
            this.groupBox_options.Controls.Add(this.checkBox_audio);
            this.groupBox_options.Controls.Add(this.comboBox_audioFormats);
            this.groupBox_options.Controls.Add(this.label5);
            this.groupBox_options.Location = new System.Drawing.Point(3, 97);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.Size = new System.Drawing.Size(538, 114);
            this.groupBox_options.TabIndex = 14;
            this.groupBox_options.TabStop = false;
            this.groupBox_options.Text = "Options";
            // 
            // comboBox_videoFormats
            // 
            this.comboBox_videoFormats.FormattingEnabled = true;
            this.comboBox_videoFormats.Location = new System.Drawing.Point(408, 42);
            this.comboBox_videoFormats.Name = "comboBox_videoFormats";
            this.comboBox_videoFormats.Size = new System.Drawing.Size(121, 21);
            this.comboBox_videoFormats.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Format";
            // 
            // checkBox_video
            // 
            this.checkBox_video.AutoSize = true;
            this.checkBox_video.Location = new System.Drawing.Point(408, 19);
            this.checkBox_video.Name = "checkBox_video";
            this.checkBox_video.Size = new System.Drawing.Size(113, 17);
            this.checkBox_video.TabIndex = 9;
            this.checkBox_video.Text = "Télécharger Vidéo";
            this.checkBox_video.UseVisualStyleBackColor = true;
            // 
            // checkBox_audio
            // 
            this.checkBox_audio.AutoSize = true;
            this.checkBox_audio.Location = new System.Drawing.Point(51, 19);
            this.checkBox_audio.Name = "checkBox_audio";
            this.checkBox_audio.Size = new System.Drawing.Size(113, 17);
            this.checkBox_audio.TabIndex = 9;
            this.checkBox_audio.Text = "Télécharger Audio";
            this.checkBox_audio.UseVisualStyleBackColor = true;
            // 
            // comboBox_audioFormats
            // 
            this.comboBox_audioFormats.FormattingEnabled = true;
            this.comboBox_audioFormats.Location = new System.Drawing.Point(51, 42);
            this.comboBox_audioFormats.Name = "comboBox_audioFormats";
            this.comboBox_audioFormats.Size = new System.Drawing.Size(121, 21);
            this.comboBox_audioFormats.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Format";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(141, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // button_paste
            // 
            this.button_paste.Location = new System.Drawing.Point(475, 21);
            this.button_paste.Margin = new System.Windows.Forms.Padding(0);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(66, 29);
            this.button_paste.TabIndex = 4;
            this.button_paste.Text = "Coller";
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(3, 71);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(458, 20);
            this.textBox_folder.TabIndex = 3;
            // 
            // textbox_link
            // 
            this.textbox_link.Location = new System.Drawing.Point(3, 26);
            this.textbox_link.Name = "textbox_link";
            this.textbox_link.Size = new System.Drawing.Size(458, 20);
            this.textbox_link.TabIndex = 2;
            // 
            // button_folder
            // 
            this.button_folder.Location = new System.Drawing.Point(475, 66);
            this.button_folder.Margin = new System.Windows.Forms.Padding(0);
            this.button_folder.Name = "button_folder";
            this.button_folder.Size = new System.Drawing.Size(67, 29);
            this.button_folder.TabIndex = 0;
            this.button_folder.Text = "Ouvrir";
            this.button_folder.UseVisualStyleBackColor = true;
            this.button_folder.Click += new System.EventHandler(this.button_folder_Click);
            // 
            // YoutubePlaylistDownloader
            // 
            this.YoutubePlaylistDownloader.Controls.Add(this.button_get_playlist);
            this.YoutubePlaylistDownloader.Controls.Add(this.button_paste_playlist);
            this.YoutubePlaylistDownloader.Controls.Add(this.button_folder_playlist);
            this.YoutubePlaylistDownloader.Controls.Add(this.textBox_folder_playlist);
            this.YoutubePlaylistDownloader.Controls.Add(this.textBox_paste_playlist);
            this.YoutubePlaylistDownloader.Controls.Add(this.listBox1);
            this.YoutubePlaylistDownloader.Location = new System.Drawing.Point(4, 22);
            this.YoutubePlaylistDownloader.Name = "YoutubePlaylistDownloader";
            this.YoutubePlaylistDownloader.Padding = new System.Windows.Forms.Padding(3);
            this.YoutubePlaylistDownloader.Size = new System.Drawing.Size(545, 278);
            this.YoutubePlaylistDownloader.TabIndex = 1;
            this.YoutubePlaylistDownloader.Text = "Playlist Downloader";
            this.YoutubePlaylistDownloader.UseVisualStyleBackColor = true;
            // 
            // button_get_playlist
            // 
            this.button_get_playlist.Location = new System.Drawing.Point(8, 75);
            this.button_get_playlist.Name = "button_get_playlist";
            this.button_get_playlist.Size = new System.Drawing.Size(530, 31);
            this.button_get_playlist.TabIndex = 7;
            this.button_get_playlist.Text = "Télécharger";
            this.button_get_playlist.UseVisualStyleBackColor = true;
            this.button_get_playlist.Click += new System.EventHandler(this.button_get_playlist_Click);
            // 
            // button_paste_playlist
            // 
            this.button_paste_playlist.Location = new System.Drawing.Point(472, 3);
            this.button_paste_playlist.Margin = new System.Windows.Forms.Padding(0);
            this.button_paste_playlist.Name = "button_paste_playlist";
            this.button_paste_playlist.Size = new System.Drawing.Size(66, 29);
            this.button_paste_playlist.TabIndex = 6;
            this.button_paste_playlist.Text = "Coller";
            this.button_paste_playlist.UseVisualStyleBackColor = true;
            this.button_paste_playlist.Click += new System.EventHandler(this.button_paste_playlist_Click);
            // 
            // button_folder_playlist
            // 
            this.button_folder_playlist.Location = new System.Drawing.Point(471, 43);
            this.button_folder_playlist.Margin = new System.Windows.Forms.Padding(0);
            this.button_folder_playlist.Name = "button_folder_playlist";
            this.button_folder_playlist.Size = new System.Drawing.Size(67, 29);
            this.button_folder_playlist.TabIndex = 5;
            this.button_folder_playlist.Text = "Ouvrir";
            this.button_folder_playlist.UseVisualStyleBackColor = true;
            this.button_folder_playlist.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_folder_playlist
            // 
            this.textBox_folder_playlist.Location = new System.Drawing.Point(8, 48);
            this.textBox_folder_playlist.Name = "textBox_folder_playlist";
            this.textBox_folder_playlist.Size = new System.Drawing.Size(451, 20);
            this.textBox_folder_playlist.TabIndex = 4;
            // 
            // textBox_paste_playlist
            // 
            this.textBox_paste_playlist.Location = new System.Drawing.Point(8, 8);
            this.textBox_paste_playlist.Name = "textBox_paste_playlist";
            this.textBox_paste_playlist.Size = new System.Drawing.Size(451, 20);
            this.textBox_paste_playlist.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(532, 160);
            this.listBox1.TabIndex = 0;
            // 
            // SoundCloudSingleLinkDownloader
            // 
            this.SoundCloudSingleLinkDownloader.Controls.Add(this.button_get_SoundCloudSingleLink);
            this.SoundCloudSingleLinkDownloader.Controls.Add(this.button_paste_SoundCloudSingleLink);
            this.SoundCloudSingleLinkDownloader.Controls.Add(this.button_folder_SoundCloudSingleLink);
            this.SoundCloudSingleLinkDownloader.Controls.Add(this.textBox_folder_soundCloudSingleLink);
            this.SoundCloudSingleLinkDownloader.Controls.Add(this.textBox_link_soundCloudSingleLink);
            this.SoundCloudSingleLinkDownloader.Location = new System.Drawing.Point(4, 22);
            this.SoundCloudSingleLinkDownloader.Name = "SoundCloudSingleLinkDownloader";
            this.SoundCloudSingleLinkDownloader.Size = new System.Drawing.Size(545, 278);
            this.SoundCloudSingleLinkDownloader.TabIndex = 2;
            this.SoundCloudSingleLinkDownloader.Text = "SoundClound Single Downloader";
            this.SoundCloudSingleLinkDownloader.UseVisualStyleBackColor = true;
            // 
            // button_get_SoundCloudSingleLink
            // 
            this.button_get_SoundCloudSingleLink.Location = new System.Drawing.Point(8, 97);
            this.button_get_SoundCloudSingleLink.Name = "button_get_SoundCloudSingleLink";
            this.button_get_SoundCloudSingleLink.Size = new System.Drawing.Size(530, 31);
            this.button_get_SoundCloudSingleLink.TabIndex = 11;
            this.button_get_SoundCloudSingleLink.Text = "Télécharger";
            this.button_get_SoundCloudSingleLink.UseVisualStyleBackColor = true;
            this.button_get_SoundCloudSingleLink.Click += new System.EventHandler(this.button_get_SoundCloudSingleLink_Click);
            // 
            // button_paste_SoundCloudSingleLink
            // 
            this.button_paste_SoundCloudSingleLink.Location = new System.Drawing.Point(472, 11);
            this.button_paste_SoundCloudSingleLink.Margin = new System.Windows.Forms.Padding(0);
            this.button_paste_SoundCloudSingleLink.Name = "button_paste_SoundCloudSingleLink";
            this.button_paste_SoundCloudSingleLink.Size = new System.Drawing.Size(66, 29);
            this.button_paste_SoundCloudSingleLink.TabIndex = 10;
            this.button_paste_SoundCloudSingleLink.Text = "Coller";
            this.button_paste_SoundCloudSingleLink.UseVisualStyleBackColor = true;
            this.button_paste_SoundCloudSingleLink.Click += new System.EventHandler(this.button_paste_SoundCloudSingleLink_Click);
            // 
            // button_folder_SoundCloudSingleLink
            // 
            this.button_folder_SoundCloudSingleLink.Location = new System.Drawing.Point(471, 51);
            this.button_folder_SoundCloudSingleLink.Margin = new System.Windows.Forms.Padding(0);
            this.button_folder_SoundCloudSingleLink.Name = "button_folder_SoundCloudSingleLink";
            this.button_folder_SoundCloudSingleLink.Size = new System.Drawing.Size(67, 29);
            this.button_folder_SoundCloudSingleLink.TabIndex = 9;
            this.button_folder_SoundCloudSingleLink.Text = "Ouvrir";
            this.button_folder_SoundCloudSingleLink.UseVisualStyleBackColor = true;
            this.button_folder_SoundCloudSingleLink.Click += new System.EventHandler(this.button_folder_SoundCloudSingleLink_Click);
            // 
            // textBox_folder_soundCloudSingleLink
            // 
            this.textBox_folder_soundCloudSingleLink.Location = new System.Drawing.Point(8, 56);
            this.textBox_folder_soundCloudSingleLink.Name = "textBox_folder_soundCloudSingleLink";
            this.textBox_folder_soundCloudSingleLink.Size = new System.Drawing.Size(451, 20);
            this.textBox_folder_soundCloudSingleLink.TabIndex = 8;
            // 
            // textBox_link_soundCloudSingleLink
            // 
            this.textBox_link_soundCloudSingleLink.Location = new System.Drawing.Point(8, 16);
            this.textBox_link_soundCloudSingleLink.Name = "textBox_link_soundCloudSingleLink";
            this.textBox_link_soundCloudSingleLink.Size = new System.Drawing.Size(451, 20);
            this.textBox_link_soundCloudSingleLink.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 432);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(549, 27);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Résolution : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bitrate : ";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(82, 29);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(0, 13);
            this.label_title.TabIndex = 5;
            // 
            // label_resolution
            // 
            this.label_resolution.AutoSize = true;
            this.label_resolution.Location = new System.Drawing.Point(82, 56);
            this.label_resolution.Name = "label_resolution";
            this.label_resolution.Size = new System.Drawing.Size(0, 13);
            this.label_resolution.TabIndex = 6;
            // 
            // label_bitrate
            // 
            this.label_bitrate.AutoSize = true;
            this.label_bitrate.Location = new System.Drawing.Point(82, 81);
            this.label_bitrate.Name = "label_bitrate";
            this.label_bitrate.Size = new System.Drawing.Size(0, 13);
            this.label_bitrate.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_bitrate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_resolution);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_title);
            this.groupBox2.Location = new System.Drawing.Point(7, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(559, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(452, 277);
            this.listBox2.TabIndex = 9;
            // 
            // trackBar_qualité
            // 
            this.trackBar_qualité.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar_qualité.Location = new System.Drawing.Point(3, 230);
            this.trackBar_qualité.Name = "trackBar_qualité";
            this.trackBar_qualité.Size = new System.Drawing.Size(539, 45);
            this.trackBar_qualité.TabIndex = 18;
            this.trackBar_qualité.Value = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Basse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Moyenne";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Haute";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 461);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl_Youtube);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader";
            this.tabControl_Youtube.ResumeLayout(false);
            this.YoutubeSingleLinkDownloader.ResumeLayout(false);
            this.YoutubeSingleLinkDownloader.PerformLayout();
            this.groupBox_options.ResumeLayout(false);
            this.groupBox_options.PerformLayout();
            this.YoutubePlaylistDownloader.ResumeLayout(false);
            this.YoutubePlaylistDownloader.PerformLayout();
            this.SoundCloudSingleLinkDownloader.ResumeLayout(false);
            this.SoundCloudSingleLinkDownloader.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_qualité)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Youtube;
        private System.Windows.Forms.TabPage YoutubeSingleLinkDownloader;
        private System.Windows.Forms.TabPage YoutubePlaylistDownloader;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_resolution;
        private System.Windows.Forms.Label label_bitrate;
        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.TextBox textbox_link;
        private System.Windows.Forms.Button button_folder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.CheckBox checkBox_audio;
        private System.Windows.Forms.ComboBox comboBox_audioFormats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.CheckBox checkBox_video;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox_folder_playlist;
        private System.Windows.Forms.TextBox textBox_paste_playlist;
        private System.Windows.Forms.Button button_paste_playlist;
        private System.Windows.Forms.Button button_folder_playlist;
        private System.Windows.Forms.Button button_get_playlist;
        private System.Windows.Forms.TabPage SoundCloudSingleLinkDownloader;
        private System.Windows.Forms.Button button_get_SoundCloudSingleLink;
        private System.Windows.Forms.Button button_paste_SoundCloudSingleLink;
        private System.Windows.Forms.Button button_folder_SoundCloudSingleLink;
        private System.Windows.Forms.TextBox textBox_folder_soundCloudSingleLink;
        private System.Windows.Forms.TextBox textBox_link_soundCloudSingleLink;
        private System.Windows.Forms.ComboBox comboBox_videoFormats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_qualité;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

