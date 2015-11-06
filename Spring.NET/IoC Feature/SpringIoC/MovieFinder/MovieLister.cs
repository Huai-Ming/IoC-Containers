using Spring.Objects.Factory.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder
{
    /// <summary>
    /// A class that provides a list of movies directed by a particular director
    /// </summary>
    public class MovieLister
    {
        private IMovieFinder finder;

        /// <summary>
        /// Create an instance of movie lister
        /// </summary>
        public MovieLister()
        {

        }

        [Required]
        public IMovieFinder Finder
        {
            set { finder = value; }
            get { return finder; }
        }

        /// <summary>
        /// Return a list of those movies directed by the supplied.
        /// </summary>
        /// <param name="director"></param>
        /// <returns></returns>
        public Movie[] MoviesDriectedBy(string director)
        {
            //Get all the movies using finder
            IList allMovies = finder.FindAll();
            IList movies = new ArrayList();

            foreach (Movie movie in allMovies)
            {
                if (director.Equals(movie.Director))
                {
                    movies.Add(movie);
                }
            }

            return (Movie[])ArrayList.Adapter(movies).ToArray(typeof(Movie));

        }
    }
}
