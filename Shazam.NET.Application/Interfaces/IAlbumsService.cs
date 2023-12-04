using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shazam.NET
{
    public interface IAlbumsService
    {
        /// <summary>
        /// Get detailed album of an album
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetDetails(int id);

        /// <summary>
        /// Get artist related to an album
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<object> GetRelatedArtist(int id);
    }
}