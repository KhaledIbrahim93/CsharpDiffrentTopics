using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_HashTable
{
    class Program
    {
       public class Demo
        {
            public Dictionary<int,string> NewDictionary { get; set; }
            public Hashtable NewHashTable { get; set; }
        }
         
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.NewDictionary.Add(1, "khaled");
            demo.NewDictionary.Add(1, "Ibrahim");
            demo.NewDictionary.Add(1, "Kamel");
            //A Dictionary is a generic collection..
            //In Dictionary, you must specify the type of key and value.
            demo.NewHashTable.Add(1, "khaled");
            demo.NewHashTable.Add("khaled", "khaled");
            //In Dictionary, you must specify the type of key and value.



        }
    }
}
