# OMDbSharp
A C# API wrapper for <a href="http://omdbapi.com/" target="_blank">omdbapi.com</a>, a free web service to obtain movie information.

Example:

<pre>var omdb = new Omdb();<br/>
var movie = await omdb.GetMovie("Blade Runner");<br/>
var posterStream = await movie.GetPosterStream();</pre>
