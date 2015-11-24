# OMDbSharp
A C# API wrapper for <a ref="http://omdbapi.com/" target="_blank">omdbapi.com</a>, a free web service to obtain movie information.

Example:

<pre>omdb newOmdb = new omdb();<br/>
movie newMovie = await newOmdb.getMovie("Blade Runner");</pre>
