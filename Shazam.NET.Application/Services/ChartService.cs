namespace Shazam.NET
{
    public class ChartService : IChartService
    {
        private readonly string _key;

        public ChartService(string key)
        {
            _key = key;
        }

        public Task<object> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> TrackAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}