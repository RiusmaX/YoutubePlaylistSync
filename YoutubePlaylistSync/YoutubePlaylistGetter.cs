using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using YoutubeExtractor;


namespace YoutubePlaylistSync
{



    class YoutubePlaylistGetter
    {
        List<string> titres = new List<string>();
        List<string> liens = new List<string>();

        internal delegate void UpdateListBoxDelegate(string txt);
        internal delegate void UpdateListBox1Delegate(string txt);
        internal static event UpdateListBoxDelegate UpdateListBox;
        internal static event UpdateListBox1Delegate UpdateListBox1;

        public void getPlaylist(string url, string path)
        {
            string code = getCodeSourcePageWeb(url);
            decodeCodeSource(code);
            foreach (string lien in liens)
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                string lienYT = lien.Trim('"');
                lienYT = "https://www.youtube.com" + lien;
                try
                {
                    IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(lien, false);
                    YoutubeGetter.getAudio(videoInfos, path);                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                UpdateListBox("Effectue en : " + elapsedTime);
            }
            
        }

        private string getCodeSourcePageWeb(string url){

            using (WebClient client = new WebClient ()) 
            {          
                //maj 14/01 - Ajout de la gestion d'un proxy
                Uri uri = WebRequest.DefaultWebProxy.GetProxy(new Uri(url));
                return client.DownloadString(uri);                    
            }

        }

        private void decodeCodeSource(string code){
            
            string[] tabSplit = {"data-title="};
            
            string[] codesplité = code.Split(tabSplit,StringSplitOptions.RemoveEmptyEntries);
            List<string> list1 = new List<string>();

            bool isTitreDejaDansLaListe = false;
            bool isLienDejaDansLaListe = false;

            string prefixlien = "data-sessionlink=";
            foreach (string s in codesplité)
	        {
                list1.Add(s);
	        }
            list1.RemoveAt(0);
            
            foreach (string s in list1)
            {
               isTitreDejaDansLaListe = false;
               isLienDejaDansLaListe = false;
               
                codesplité = s.Split(new char[] { '>' });
                string titre = codesplité[0].Trim(new Char['\"']);
                if(titre.Contains("data-video-id")){
                    titre = titre.Substring(titre.IndexOf("\""),titre.IndexOf("data-video-id"));
                }

                foreach (string s4 in titres)
                {
                    if (titre.Equals(s4))
                    {
                        isTitreDejaDansLaListe = true;
                    }
                }
                if (!isTitreDejaDansLaListe)
                {
                    titres.Add(titre);
                    foreach (string s2 in codesplité)
                    {
                        if (!isLienDejaDansLaListe)
                        {
                            if (s2.Contains(prefixlien))
                            {
                                string[] lienTab = s2.Split(new string[] { prefixlien }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string s3 in lienTab)
                                {
                                    if (s3.Contains("class"))
                                    {
                                        lienTab = s3.Split(new string[] { "class" }, StringSplitOptions.RemoveEmptyEntries);
                                        string lien_partiel = lienTab[0].Substring(lienTab[0].IndexOf("\""), lienTab[0].IndexOf(";"));
                                        string lien = lien_partiel.Substring(lien_partiel.IndexOf("/"), lien_partiel.IndexOf(";"));
                                        liens.Add(lien);                                        
                                        isLienDejaDansLaListe = true;
                                    }

                               }
                           }
                        }
                       
                    }
                }
               
            }
            int i=0;
            foreach (string titre in titres)
            {
                if (titre != null)
                {
                    UpdateListBox1(titre);                                  
                }
                i++;
               
            }

        }

        



    }
}
