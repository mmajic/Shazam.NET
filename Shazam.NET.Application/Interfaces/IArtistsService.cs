using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazam.NET
{
    public interface IArtistsService
    {
        /// <summary>
        /// Get detailed information of an artist
        /// </summary>
        /// <returns></returns>
        public Task<object> GetDetailsAsync(int id);

        /// <summary>
        /// Get top songs of an artist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetTopSongsAsync(int id);

        /// <summary>
        /// Get latest release of an artist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetLatestReleaseAsync(int id);

        /// <summary>
        /// Get summary information related to an artist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetSummaryAsync(int id);
    }
}