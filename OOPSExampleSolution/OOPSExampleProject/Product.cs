using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExampleProject
{
    class Product
    {
        int id;
        string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public void PrintProduct() //head --access specifier return type Identifier(Parameters)
        {
            Console.WriteLine("Product Id" + id);
            Console.WriteLine("Product Name" + name);
        }

        public void CreateProduct()
        {
            Console.WriteLine("Please enter the product ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the product name");
            name = Console.ReadLine();
        }
        //function
         public int add()
        {
            int n1, n2,c;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            c = n1 + n2;
            return c;


        }
    }
}
