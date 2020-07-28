using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExampleProject
{
    class Divisibleby7
    {
        /*
        public void Divisibility()
        {
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 7 == 0)
            {
                Console.WriteLine(n +" is divisible by 7");
            }
            else
            {
                Console.WriteLine(n +"is not divisible by 7");
            }
        }*/
        public void Greatest()
        {
            int a, b, c;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a+" is greater");
                }
                else
                    Console.WriteLine(c+" is greater");
            }
            else if(a==b)
            {
                if(a==c)
                {
                    Console.WriteLine("all are equal");
                }
            }
            else
            {
                if (b > c)
                    Console.WriteLine(b+" is greater");
                else
                    Console.WriteLine(c+" is greater");
            }


        }
    }
}