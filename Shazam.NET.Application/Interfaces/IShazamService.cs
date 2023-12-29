using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shazam.NET
{
    /// <summary>
    /// Shazam service interface
    /// parameters and return types incomplete
    /// </summary>
    public interface IShazamService
    {
        /// <summary>
        /// List future events
        /// </summary>
        /// <returns>future events object</returns>
        public Task<object> ListShazamEventsAsync();

        /// <summary>
        /// Search for songs, artists that match input term
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public Task<SearchResponse> SearchAsync(string term);

        /// <summary>
        /// Get suggestions by word or phrase
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public Task<object> AutoCompleteAsync(string term);
    }
}