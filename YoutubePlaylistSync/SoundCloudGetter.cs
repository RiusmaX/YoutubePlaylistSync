using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;


namespace YoutubePlaylistSync
{
    class SoundCloudGetter
    {
        internal delegate void UpdateListBoxDelegate(string txt);
        internal static event UpdateListBoxDelegate UpdateListBox;
        private static string title = "";
        private static string artist = "";

        public void getSoundCloudSound(string url, string path) 
        {
             Macros m = new Macros();             
             getSoundCloudFile(m.controlWebPage(url),path);
        }
       
        private void getSoundCloudFile(string songLink,string path)
        {   
            using (WebClient client = new WebClient())
            {
                string link = songLink;
                path += RemoveIllegalPathCharacters(artist.Replace("-", " ") + " - " + title.Replace("-", " "));
                if (songLink.Contains(".mp3"))
                {
                    path += ".mp3";
                }else {
                      path += ".wav";
                }               
                client.DownloadFile(songLink, path);
            }
        }

        [TestFixture]
        class Macros
        {

            [Test]
            public string controlWebPage(string url)
            {
                Update
                string link = "";
                var driverService = PhantomJSDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                IWebDriver driver = new PhantomJSDriver(driverService);
                driver.Navigate().GoToUrl("http://streampocket.com/");
                driver.FindElement(By.Id("stream")).Clear();
                driver.FindElement(By.Id("stream")).SendKeys(url);
                driver.FindElement(By.Id("submit")).Click();
                for (int second = 0; ; second++)
                {
                    if (second >= 60) Assert.Fail("timeout");
                    try
                    {
                        if (driver.FindElement(By.Id("tape")).Displayed) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }
                string[] tab = url.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                artist = tab[2];
                title = tab[3];
                link = driver.FindElement(By.Id("tape")).GetAttribute("href");
                driver.Quit();
                return link;
            }

        }

        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "").Replace(" ", "-");
        }


    }
}
