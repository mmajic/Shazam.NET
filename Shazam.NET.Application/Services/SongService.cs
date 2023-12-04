namespace Shazam.NET
{
    internal class SongService : ISongService
    {
        private readonly string _key;

        public SongService(string key)
        {
            _key = key;
        }

        public Task<object> DetectAsync(byte[] rawArray)
        {
            throw new NotImplementedException();
        }

        public Task<object> DetectV2Async(byte[] rawArray)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetCountAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetDetails(string key)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetDetailsV2Async(string id)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetRelatedArtistAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<object> ListArtistTopTracksAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> ListRecommendationsAsync(string key)
        {
            throw new NotImplementedException();
        }
    }
}