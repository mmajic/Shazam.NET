namespace Shazam.NET
{
    public interface IChartService
    {
        /// <summary>
        /// List all available charts by cities, countries, and genres
        /// </summary>
        /// <returns></returns>
        public Task<object> ListAsync();

        /// <summary>
        /// Get all popular songs in a specific chart
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> TrackAsync(string id);
    }
}