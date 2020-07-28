using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ProductManager productManager = new ProductManager();
              productManager.CreateProduct();
              productManager.PrintProductDetails();
            // productManager.callmethodofotherclass();
              Console.ReadKey();*/

            /* Supplier supplier1 = new Supplier();
             supplier1.Id = 100;
             supplier1.Name = "Rahul";
             supplier1.Amount = 8889894.89;
             supplier1.PrintDetails();
             Supplier supplier2= new Supplier();
             supplier2.Id= 190;
             supplier2.Name = "Parul";
             supplier2.Amount = 87849590.90;
             supplier2.PrintDetails();
             double totalamount = supplier1.Amount + supplier2.Amount;
             Console.WriteLine("Total Amount" + totalamount);
             Console.ReadKey();*/

            /* string strname = "Ramu";
             strname = strname.ToLower();
             Console.WriteLine(strname);
             Console.ReadKey(); */

            /* var data = "Hello";
            // data = 123;   // not  possible C# is type safe.
             Console.WriteLine(data);
             Console.ReadKey(); */

            /* int inum = 10;
               float fnum = 533.1f;
               double dnum = 5343.1;
               string snum = "100"; 
               fnum = inum;              //no data loss
                Console.WriteLine(fnum);
                dnum = fnum;              //8b =4b -no data loss
                Console.WriteLine(dnum);
                inum = (int)fnum;         //4b = 3b.1b=>data loss->explicitly
                Console.WriteLine(inum);
                fnum = (float)dnum;          //4b=8b=>data loss typecasting
                Console.WriteLine(fnum);
                dnum = Convert.ToDouble(snum);   //unboxing refernce type to value type
                Console.WriteLine(dnum); 
                snum = inum.ToString();         //boxing value type to refernce type
                Console.ReadKey();   */

            /*SpecialClass ob = new SpecialClass();
             ob.SpecialShow();
           // new SpecialClass().SpecialShow();
               ob = null;
               GC.Collect();
               Console.ReadKey(); */

            /* Divisibleby7 obj1 = new Divisibleby7();
             // obj1.Divisibility();
             obj1.Greatest();
             Console.ReadKey();*/

           /* Doctor d = new Doctor();
            d.createdoctor();
            d.printdetails();
            d = null;
            GC.Collect();
            Console.ReadKey();*/
        }
    }
}
