using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject
{
    class Movie
    {
        int id;
        string name;
        int duration;

        public void printMovieDetails()
        {
            /*id = 40;
            name = "RUPAL";
            duration = 1;*/

            Console.WriteLine("Movie id is" +id);
            Console.WriteLine("Movie name is"+name);
            Console.WriteLine("Movie duration is"+duration);
        }
        /*public void values()
        {

            Console.WriteLine("Movie id is" + id);
            Console.WriteLine("Movie name is" + name);
            Console.WriteLine("Movie duration is" + duration);
        }*/

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Duration { get => duration; set => duration = value; }
    }
}
