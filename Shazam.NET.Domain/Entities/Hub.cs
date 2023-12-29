using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazam.NET
{
    public class Hub
    {
        public string type { get; set; }
        public string image { get; set; }
        public List<Action> actions { get; set; }
        public List<Option> options { get; set; }
        public List<Provider> providers { get; set; }
        public bool @explicit { get; set; }
        public string displayname { get; set; }
    }
}