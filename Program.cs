using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Getting_user_inputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Whats your name: ");
            string name   = Console.ReadLine();
            Console.WriteLine("Hi "+name);
            Console.WriteLine("How old are you");
            string age =  Console.ReadLine();
            Console.WriteLine("You are " + age); 
            Console.ReadLine();
        }
    }
}
