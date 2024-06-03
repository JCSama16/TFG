using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFG
{
    public class VideoInfo
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime DownloadDate { get; set; }
        public string Tipo { get; set; }
        public string Ubicacion { get; set; }   
    }
}
