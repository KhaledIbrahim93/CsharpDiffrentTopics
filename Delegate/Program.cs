using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operations operation = new Operations();
            //DelegateDemo.OperationDelegate operationDelegate = new DelegateDemo.OperationDelegate(operation.Add);
            //Console.WriteLine("Enter Number 1");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number 2");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sumtion of Numbers is"+operationDelegate(x,y));
            //Console.WriteLine("Substration of Numbers is"+operationDelegate(x,y));

            ///////////////////////////////////////////////////
            //Operations operation = new Operations();
            //DelegateDemo.Message operationDelegate = new DelegateDemo.Message(operation.PrintMassage);
            //Console.WriteLine("Enter Meassege");
            //string msg = Console.ReadLine();
            //Console.WriteLine(operationDelegate(msg));
            ///////////////////////////////////////////////////////////////////////

            /// Using Delete with lambda expression
            //DelegateDemo.Number number = x => x * x;
            //DelegateDemo.Output output = () => "Welcome Khaled";
            //Console.WriteLine("Enter Number ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Squer Of Number is "+number(y));
            //Console.WriteLine(output());
            ///////////////////////////////////////////////////////////////////////
            ///Bulit-In Gelegate
            /// //Func delegate enables you to create a method that can be passed as a parameter
            //This delegate can refer to a method that takes up to 16 Parameters and returns a value. 
            //The last type parameter is used for the return type. ===>Important
            Operations operation = new Operations();
            Func<string> ShowMessage = operation.ShowWelcome;
            //this Delegate assigne to function that take no paramter and return String
            Console.WriteLine(ShowMessage());
            Console.WriteLine("Enter Number 1");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int y = int.Parse(Console.ReadLine());
            Func<int, int, int> GetSumtion = operation.Add;
            Func<int, int, int> GetSub = operation.Sub;
            //Search On Action delegate ;
            Console.WriteLine("Sumtion is "+GetSumtion(x,y)+"Sub is ....."+GetSub(x,y));
            Console.ReadKey();
        }
    }
}
