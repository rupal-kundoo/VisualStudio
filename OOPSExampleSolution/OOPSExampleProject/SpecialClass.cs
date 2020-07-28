using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExampleProject
{
    class SpecialClass
    {
       public SpecialClass()
        {
            Console.WriteLine("Hey look you have constructed a object");
        }
        ~SpecialClass()
        {
            Console.WriteLine("object going going gone");
        }
        public void SpecialShow()
        {
          int iNum1 = int.MaxValue;
            //checked    //checked block
            //     {
            //         Console.WriteLine(iNum1);
            //         iNum1++;
            //         Console.WriteLine(iNum1);
            //     } 

           string strnum = null;
          // iNum1 =int.Parse(strnum);      //Will not handle null
           // Console.WriteLine(iNum1);
           // iNum1=Convert.ToInt32(strnum); //will handle null
           // Console.WriteLine(iNum1);
            Console.WriteLine("enter a number");
            if (int.TryParse(Console.ReadLine(), out iNum1)==false)    //error handling
                Console.WriteLine("invalid input");
            iNum1 = iNum1 + 10;
            Console.WriteLine(iNum1);

            /*static void Main(string[] a)
             {
                 new SpecialClass().SpecialShow();  //anon object
                 GC.Collect();
                 Console.ReadKey();
             }*/
        }
    }
}
