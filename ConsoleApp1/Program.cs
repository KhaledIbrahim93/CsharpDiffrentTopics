using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Reflection
    {
        public string Name { get; set; }
        public int Add(int x, int y)
        {
          return x + y;
           // Console.WriteLine("Sumiotn is "+z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Reflection);
            //var instence = Activator.CreateInstance(type);
            var mettod = type.GetMethod("Add");

            Console.ReadKey();

           
        }
    }
}
