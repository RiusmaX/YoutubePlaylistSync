using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text.RegularExpressions;
using YoutubeExtractor;
using Microsoft.VisualBasic;
using TagLib;

namespace YoutubePlaylistSync
{
    class YoutubeGetter
    {
        internal delegate void UpdateProgressDelegate(double progress);
        internal delegate void UpdateListBoxDelegate(string txt);
        internal static event UpdateProgressDelegate UpdateProgress;
        internal static event UpdateListBoxDelegate UpdateListBox;
        internal delegate void ExecuteDelegate();
        internal static event ExecuteDelegate Execute;

        public static void getVideo(IEnumerable<VideoInfo> videoInfos, String path)
        {

            UpdateListBox("[INFO] Récupération des informations de la vidéo");
            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            

            if (video.RequiresDecryption)
            {
                UpdateListBox("[INFO] Décryptage");
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }
            string title = RemoveIllegalPathCharacters(video.Title);

            if (!new System.IO.FileInfo(path + title + ".mp4").Exists || !new System.IO.FileInfo(path + RemoveIllegalPathCharactersForRename(video.Title) + ".mp3").Exists)
            {
                var videoDownloader = new VideoDownloader(video, path + title + video.VideoExtension);

                videoDownloader.DownloadProgressChanged += (sender, args) => UpdateProgress(args.ProgressPercentage);
                //videoDownloader.DownloadProgressChanged += (sender, args) => UpdateListBox("Téléchargement : " + Convert.ToString(args.ProgressPercentage) + "%");
                UpdateListBox("[INFO] Téléchargement");

                Thread execute = new Thread(videoDownloader.Execute);
                execute.Start();
            }

        }

        public static IEnumerable<VideoInfo> getVideoInformations(string link)
        {
            IEnumerable<VideoInfo> videoInfos = null;
            try
            {
                videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false);
            }
            catch (Exception e)
            {
                UpdateListBox(e.Message);
            }
            return videoInfos;
        }
        //, VideoType format, string audioformat, int resolution, int bitrate
        public static void getAudio(IEnumerable<VideoInfo> videoInfos, String path)
        {

            UpdateListBox("[INFO] Récupération des informations de la vidéo");
            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);


            if (video.RequiresDecryption)
            {
                UpdateListBox("[INFO] Décryptage");
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }
            string title = RemoveIllegalPathCharacters(video.Title);

            if (!new System.IO.FileInfo(path + title + ".mp3").Exists || !new System.IO.FileInfo(path + RemoveIllegalPathCharactersForRename(video.Title) + ".mp3").Exists)
            {
                var videoDownloader = new VideoDownloader(video, path + title + video.VideoExtension);

                videoDownloader.DownloadProgressChanged += (sender, args) => UpdateProgress(args.ProgressPercentage);
                //videoDownloader.DownloadProgressChanged += (sender, args) => UpdateListBox("Téléchargement : " + Convert.ToString(args.ProgressPercentage) + "%");
                UpdateListBox("[INFO] Téléchargement");

                videoDownloader.Execute();
                
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = "ffmpeg";
                proc.StartInfo.Arguments = "-i " + path + title + video.VideoExtension + " -y -ab 320k " + path + title + ".mp3";
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.UseShellExecute = false;
                if (!proc.Start())
                {
                    UpdateListBox("Error starting");
                    return;
                }
                StreamReader reader = proc.StandardError;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(line.Contains("size")){
                         UpdateListBox(line);
                    }
                }
                proc.Close();

                System.IO.FileInfo fi = new System.IO.FileInfo(path + title + video.VideoExtension);
                try
                {
                    fi.Delete();
                    string pathtoOldmp3 = path + title + ".mp3";
                    string newPath = path + RemoveIllegalPathCharactersForRename(video.Title) + ".mp3";
                    FileSystem.Rename(pathtoOldmp3, newPath);
                    TagLib.File f = TagLib.File.Create(newPath);
                    string[] tags = video.Title.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                    if (tags.Length >= 1)
                    {
                        f.Tag.Title = tags[0];
                    }
                    if (tags.Length >= 2)
                    {
                        f.Tag.AlbumArtists = new string[] { tags[0] };
                        f.Tag.Title = tags[1];
                    }
                    f.Save();
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else UpdateListBox("Le fichier existe déjà");
        }

        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "").Replace(" ", "-");
        }

        private static string RemoveIllegalPathCharactersForRename(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }
    }
}
