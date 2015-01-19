using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubePlaylistSync
{
    class VideoInformations
    {
        private int bitrate;

        private int resolution;

        private string titre;

        public int getBitrate()
        {
            return bitrate;
        }

        public int getResolution()
        {
            return resolution;
        }

        public string getTitre()
        {
            return titre;
        }

        public void setBitrate(int bitrate)
        {
            this.bitrate = bitrate;
        }

        public void setResolution(int resolution)
        {
            this.resolution = resolution;
        }

        public void setTitre(string titre)
        {
            this.titre = titre;
        }


    }
}
