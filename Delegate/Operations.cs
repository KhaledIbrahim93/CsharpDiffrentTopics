using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
  public class Operations
    {
        public int Add(int x, int y)
        {
           return x + y;
           
        }
        public int Sub(int x, int y)
        {
          return x - y;
        }
        public string PrintMassage(string msg)
        {
            return string.Format("Welcome" + msg);
        }
        public string ShowWelcome()
        {
            return string.Format("Welcome at Built-In Delegate");
        }
        public string ShowInformation(string firstName, string lastName)
        {
            return string.Format("Your Name is {0} {1}", firstName, lastName);
        }
    }
}
