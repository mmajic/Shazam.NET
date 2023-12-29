namespace Shazam.NET
{
    public class Option
    {
        public string caption { get; set; }
        public List<Action> actions { get; set; }
        public Beacondata beacondata { get; set; }
        public string image { get; set; }
        public string type { get; set; }
        public string listcaption { get; set; }
        public string overflowimage { get; set; }
        public bool colouroverflowimage { get; set; }
        public string providername { get; set; }
    }
}