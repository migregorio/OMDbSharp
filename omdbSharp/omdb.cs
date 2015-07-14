using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace omdbSharp
{
    public class omdb
    {
        const string omdbUrl = "http://www.omdbapi.com/?"; // Base omdb api URL
        public string omdbKey; // A key is required for poster images.
        public movie newMovie; // Initialize movie object
        public movielist newMovieList; // Initialize movie list object
        public async Task<movie> getMovie(string query, string apiKey = "")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(omdbUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(omdbUrl + "t=" + query);
                if (response.IsSuccessStatusCode)
                {
                    newMovie = await response.Content.ReadAsAsync<movie>();
                    return newMovie;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<movielist> getMovieList(string query, string apiKey = "")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(omdbUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(omdbUrl + "s=" + query);
                if (response.IsSuccessStatusCode)
                {
                    newMovieList = await response.Content.ReadAsAsync<movielist>();
                    return newMovieList;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}