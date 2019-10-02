using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
   public  class DelegateDemo
    {
        public delegate int OperationDelegate(int x, int y);
        public delegate string Message(string mesg);
        public delegate int Number(int x);
        public delegate string Output();
    }
}
