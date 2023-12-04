namespace Shazam.NET
{
    public class ShazamSongService : IShazamSongService
    {
        private readonly string _key;

        public ShazamSongService(string key)
        {
            _key = key;
        }

        public Task<object> GetDetailsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> ListSimilaritiesAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}