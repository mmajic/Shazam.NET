namespace Shazam.NET
{
    public interface IShazamSongService
    {
        /// <summary>
        /// Get mapping id information between systems to use with other endpoints
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetDetailsAsync(int id);

        /// <summary>
        /// Get similar (You may also like) songs
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> ListSimilaritiesAsync(int id);
    }
}