using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazam.NET
{
    public interface ISongService
    {
        /// <summary>
        /// Detect songs from raw sound data. The raw sound data must be 44100Hz, 1 channel (Mono), signed 16 bit PCM lit...
        /// Tutorial: https://rapidapi.com/apidojo/api/shazam/tutorials/how-to-use-...%2Fsongs%2Fdetect-endpoint
        /// </summary>
        /// <param name="rawArray"></param>
        /// <returns></returns>
        public Task<object> DetectV2Async(byte[] rawArray);

        /// <summary>
        /// Detect songs from raw sound data. The raw sound data must be 44100Hz, 1 channel (Mono), signed 16 bit PCM lit...
        /// Tutorial: https://rapidapi.com/apidojo/api/shazam/tutorials/how-to-use-...%2Fsongs%2Fdetect-endpoint
        /// </summary>
        /// <param name="rawArray"></param>
        /// <returns></returns>
        [Obsolete("This method is depricated. Please use DetectV2Async")]
        public Task<object> DetectAsync(byte[] rawArray);

        /// <summary>
        /// Get details information of a specific song
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetDetailsV2Async(string id);

        /// <summary>
        /// Get artist related to a song
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetRelatedArtistAsync(string id);

        /// <summary>
        /// List related ones to a specific song
        /// </summary>
        /// <returns></returns>
        /// <param name="key"></param>
        /// <exception cref="NotImplementedException"></exception>
        [Obsolete("This method is depricated")]
        public Task<object> ListRecommendationsAsync(string key);

        /// <summary>
        /// List top tracks of specific artist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Obsolete("This method is depricated")]
        public Task<object> ListArtistTopTracksAsync(int id);

        /// <summary>
        /// Gets total times the specific song is detected using DetectV2Async or DetectAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetCountAsync(string id);

        /// <summary>
        /// Get details information of a specific song
        /// </summary>
        /// <returns></returns>
        [Obsolete("This method is depricated. Please use GetDetailsV2Async")]
        public Task<object> GetDetails(string key);
    }
}