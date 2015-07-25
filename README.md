# OMDbSharp
A C# API wrapper for omdbapi.com, a free web service to obtain movie information.

Example:

<pre>omdb newOmdb = new omdb();<br/>
movie newMovie = await newOmdb.getMovie("Blade Runner");</pre>
