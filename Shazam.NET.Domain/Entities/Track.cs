using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Shazam.NET
{
    public class Track
    {
        public string layout { get; set; }
        public string type { get; set; }
        public string key { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public Share share { get; set; }
        public Images images { get; set; }
        public Hub hub { get; set; }
        public List<Artist> artists { get; set; }
        public string url { get; set; }
    }
}