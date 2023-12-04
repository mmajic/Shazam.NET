namespace Shazam.NET
{
    public class ShazamService : IShazamService
    {
        private readonly string _key;

        public ShazamService(string key)
        {
            _key = key;
        }

        public Task<object> AutoCompleteAsync(string term)
        {
            throw new NotImplementedException();
        }

        public Task<object> ListShazamEventsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAsync(string term)
        {
            throw new NotImplementedException();
        }
    }
}