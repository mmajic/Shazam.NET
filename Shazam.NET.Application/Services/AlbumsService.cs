namespace Shazam.NET
{
    public class AlbumsService : IAlbumsService
    {
        private readonly string _key;

        public AlbumsService(string key)
        {
            _key = key;
        }

        public Task<object> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetRelatedArtist(int id)
        {
            throw new NotImplementedException();
        }
    }
}