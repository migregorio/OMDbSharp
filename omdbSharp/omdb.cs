using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OmdbSharp
{
    public class Omdb
    {
        const string omdbUrl = "http://www.omdbapi.com/?"; // Base omdb api URL
        public string omdbKey; // A key is required for poster images.
        public Movie newMovie; // Initialize movie object
        public MovieList newMovieList; // Initialize movie list object
        public async Task<Movie> GetMovie(string query, string apiKey = "")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(omdbUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(omdbUrl + "t=" + query);
                if (response.IsSuccessStatusCode)
                {
                    newMovie = await response.Content.ReadAsAsync<Movie>();
                    return newMovie;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<MovieList> GetMovieList(string query, string apiKey = "")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(omdbUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(omdbUrl + "s=" + query);
                if (response.IsSuccessStatusCode)
                {
                    newMovieList = await response.Content.ReadAsAsync<MovieList>();
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