using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazam.NET
{
    public class Provider
    {
        public string caption { get; set; }
        public Images images { get; set; }
        public List<Action> actions { get; set; }
        public string type { get; set; }
    }
}