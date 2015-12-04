using System;

namespace OmdbSharp
{
    public class MovieList
    {
        public Search[] Search { get; set; }
    }
    public class Search
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
    }
}