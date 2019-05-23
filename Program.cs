using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
             string name= Console.ReadLine();
            Console.WriteLine("What is your Address?");
            string address = Console.ReadLine();
            Console.WriteLine("What is your Mobile?");
            string mobile = Console.ReadLine();
            Console.WriteLine("What is your Date of Birth?");
            string date = Console.ReadLine();
            Console.WriteLine("What is your Age?");
            string age = Console.ReadLine();
            Console.WriteLine("Name:" +name);
            Console.WriteLine("Address:" + address);
            Console.WriteLine("Mobile:" + mobile);
            Console.WriteLine("Date of Birth:" + date);
            Console.WriteLine("Age:" + age);
            Console.ReadKey();
        }
    }
}
