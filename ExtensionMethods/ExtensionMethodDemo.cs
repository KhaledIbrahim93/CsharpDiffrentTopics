using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
   public static class ExtensionMethodDemo
    {
       // As its name itself indicates that it extends the functionality of an existing type in .NET
        public static string Welcome(this string s)
        {
            return string.Format("Welcome" + s);
        }
        public static string AddWelcome(this string s,string msg)
        {
            return string.Format(msg+ s);
        }
       public static int GetFactoral(this int n)
        {
            int fact = 1;
            for (int j = n; j > 0; j--)
            {
                fact = fact * j;
            }
            return fact;
        }
//  Extension Methods must be located in a static class.
//  Extension Methods are static methods.
//  It uses the "this" keyword as the first parameter with a type in .NET and this method will be called by a given type instance.
//  When we press the dot(.) after a type instance, then Extension Methods will come in VS intellisense.
//  An extension method should be in the same namespace, if not then you have to import the namespace of the class by a using statement.
    }
}
