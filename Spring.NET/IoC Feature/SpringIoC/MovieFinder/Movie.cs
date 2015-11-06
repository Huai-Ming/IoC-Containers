using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder
{
    /// <summary>
    /// An object that describle the movie
    /// </summary>
    public class Movie
    {
        private string director;
        private string title;

        public Movie(string title, string director)
        {
            this.title = title;
            this.director = director;
        }

        public string Director
        {
            set;
            get;
        }

        public string Title
        {
            set;
            get;
        }
    }
}
