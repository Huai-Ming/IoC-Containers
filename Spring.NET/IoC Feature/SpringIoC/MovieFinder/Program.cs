using Common.Logging;
using log4net;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder
{
    /// <summary>
    /// A simple application that demonstrates the IoC functionality of Spring.NET.
    /// </summary>
    public sealed class Program
    {
        //Here we will define the log to trace the applciation.
        private static readonly ILog LOG = LogManager.GetLogger(typeof(Program));

        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                 //First we get the context of spring to instantiate the object we needed.
                IApplicationContext context = ContextRegistry.GetContext();
                MovieLister lister = (MovieLister)context.GetObject("MyMovieLister");
                Movie[] movies = lister.MoviesDriectedBy("Roberto Benigni");
                LOG.Debug("Searching for movie...");
                foreach (Movie movie in movies)
                {
                    //LOG.Debug(
                    //    string.Format("Movie Title = '{0}', Director = '{1}'.",
                    //                  movie.Title, movie.Director));
                    Console.WriteLine("Movie Title = '{0}', Director = '{1}'.",
                                      movie.Title, movie.Director);
                }
                //LOG.Debug("MovieApp Done.");
            }
            catch(Exception  e)
            {
                //LOG.Error("Movie Finder is broken.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("---Hit and return.---");
                Console.Read();
            }
        }
    }
}
