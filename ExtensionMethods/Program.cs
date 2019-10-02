using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string k = Console.ReadLine();
            Console.WriteLine("Enter Number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(k.Welcome());
            Console.WriteLine(k.AddWelcome(k));
            Console.WriteLine(x.GetFactoral());
            Console.ReadKey();
        }
    }
}
