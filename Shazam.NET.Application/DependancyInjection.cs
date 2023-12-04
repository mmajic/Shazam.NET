using Microsoft.Extensions.DependencyInjection;

namespace Shazam.NET
{
    public static class DependancyInjection
    {
        /// <summary>
        /// Adds Shazam.NET services to the service collection. Requires a Rapidapi Shazam key.
        /// Can be obtained from https://rapidapi.com/apidojo/api/shazam
        /// </summary>
        /// <param name="services"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static IServiceCollection AddShazam(this IServiceCollection services, string key)
        {
            services.AddSingleton<IShazamService>(provider => new ShazamService(key));

            services.AddSingleton<IAlbumsService>(provider => new AlbumsService(key));

            services.AddSingleton<IChartService>(provider => new ChartService(key));

            services.AddSingleton<IShazamSongService>(provider => new ShazamSongService(key));

            services.AddSingleton<ISongService>(provider => new SongService(key));

            return services;
        }
    }
}