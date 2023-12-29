using Shazam.NET;

namespace Shazam.Net.Tests
{
    [TestClass]
    public class ShazamServiceTests
    {
        public ShazamServiceTests()
        {
            // set environment variable for testing
            // https://rapidapi.com/apidojo/api/shazam/pricing
            Environment.SetEnvironmentVariable("RAPIDAPI_SHAZAM_KEY", "{key}");
        }

        [TestMethod]
        public async Task SearchAsync_ReturnsResults()
        {
            // Arrange
            var apiKey = Environment.GetEnvironmentVariable("RAPIDAPI_SHAZAM_KEY");
            var shazamService = new ShazamService(apiKey);
            var searchTerm = "Daleka Obala";

            // Act
            var result = await shazamService.SearchAsync(searchTerm);

            // Assert
            Assert.IsNotNull(result, "SearchAsync should return results.");
            Assert.IsTrue(result.tracks.hits.Count > 0, "SearchAsync should return at least one result.");
            Assert.IsInstanceOfType(result, typeof(SearchResponse), "SearchAsync should return a SearchResponse object.");
            Assert.IsNotNull(result.tracks.hits[0].track, "SearchAsync should return a track.");
        }
    }
}