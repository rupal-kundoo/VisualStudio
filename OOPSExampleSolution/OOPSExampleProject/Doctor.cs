using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExampleProject
{
    class Doctor
    {
        string doctorname;
        int age;
        float experience;
        double phone;

        public string Doctorname { get => doctorname; set => doctorname = value; }
        public int Age { get => age; set => age = value; }
        public float Experience { get => experience; set => experience = value; }
        public double Phone { get => phone; set => phone = value; }

        public Doctor()
        {
            experience = 1;
            Console.WriteLine("Experience is 1 year");
        }
        public void createdoctor()
        {
            Console.WriteLine("Please enter the Doctor name");
            doctorname = Console.ReadLine();
            Console.WriteLine("Please enter doctor age");
             age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter doctor experience");
             experience = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter doctor PHONE");
            Phone = Convert.ToDouble(Console.ReadLine());
        }
        public void printdetails()
        {
            Console.WriteLine("Doctor name is" + doctorname);
            Console.WriteLine("Doctor age is" + age);
            Console.WriteLine("Doctor experience is"+ experience);
            Console.WriteLine("Phone no is"+ Phone);

        }
        ~Doctor()
        {
            Console.WriteLine("bye from Dr." + doctorname);
        }

    }
}
