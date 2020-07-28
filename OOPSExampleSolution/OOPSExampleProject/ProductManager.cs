using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExampleProject
{
    class ProductManager
    {
        //create ref
        Product p1;
        //p!=p;
        //Method
        public void CreateProduct()
        {
            //instantiation the ref
            /* Product p1 = new Product();*/     //wrong because how PrintProductDetails will access id and name now.
            p1 = new Product();
            p1.Id=101;
            p1.Name ="Pencil";

        }
        public void PrintProductDetails()
        {
            Console.Write("The ref is");
            Console.WriteLine(p1);
            Console.WriteLine("Done");
            p1.PrintProduct();  //id,name values that has been intialized in CreateProduct will be printed.
            p1.CreateProduct(); //user data will be entered and id,product name value be changed to the values entered by the user.
            Console.WriteLine("Product Id is" + p1.Id);
            Console.WriteLine("Product Name is" + p1.Name);
            int sum=p1.add();
            Console.WriteLine("The result is" + sum);
        }
       /* public void callmethodofotherclass()
        {
            p1.PrintProduct();
        }*/
    }
}
