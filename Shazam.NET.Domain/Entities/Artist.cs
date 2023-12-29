using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazam.NET
{
    public class Artist
    {
        public string id { get; set; }
        public string adamid { get; set; }
        public List<Hit> hits { get; set; }
    }
}