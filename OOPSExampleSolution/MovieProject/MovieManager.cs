using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject
{
    class MovieManager
    {
        Movie m;

        public void CreateMovie()
        {
            m = new Movie();
            m.Id = 50;
            m.Name = "Rang de basanti";
            m.Duration = 3;
            m.printMovieDetails();
           // m.values();
        }
    }
}
