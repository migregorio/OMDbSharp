using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OmdbSharp
{
    public static class MovieExtensionMethods
    {
        public static async Task<MemoryStream> GetPosterStream(this Movie movie)
        {
            if (movie.Poster == null)
                return null;

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(movie.Poster).Result;
                if (response == null || response.StatusCode != HttpStatusCode.OK)
                {
                    return null;
                }

                var stream = await response.Content.ReadAsStreamAsync();
                var memoryStream = new MemoryStream();
                await stream.CopyToAsync(memoryStream);
                return memoryStream;
            }
        }
    }
}
