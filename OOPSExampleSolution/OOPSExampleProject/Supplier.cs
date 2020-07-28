using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExampleProject
{
    class Supplier
    {
        int id;
        string name;
        double amount;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Amount { get => amount; set => amount = value; }

        public void PrintDetails()
        {
            Console.WriteLine("Supplier id is" + id);
            Console.WriteLine("Supplier name is" + name);
            Console.WriteLine("Supplier amount is" + amount);
        }
    }
}
