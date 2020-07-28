using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieManager moviemanager = new MovieManager();
            moviemanager.CreateMovie();
            Console.ReadLine();
        }
    }
}
