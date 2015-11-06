using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder
{
    /// <summary>
    /// Describes the interface for finding a list of movies independent of <i>how</i>
    /// said movies are actually stored (text file, database, etc).
    /// </summary>
    public interface IMovieFinder
    {
        IList FindAll();
    }
}
