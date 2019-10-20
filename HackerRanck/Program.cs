using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanck
{
    class Program
    {
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            /*-------------------------------------- Problem 1 -------------------------------------------*/
            //int[] arr = { 1, 2, 3, 4, 10, 11 };
            //int result = ArraySumtionDemo.SimpleArraySum(arr);
            //Console.WriteLine("Sumtion is"+result);
            //Console.ReadLine();
            /*-------------------------------------- Problem 2 -------------------------------------------*/
            // List<int>list1  = new List<int>() { 17 ,28 ,30 };
            //List<int> list2 = new List<int>() { 99, 16, 8 };
            //var list = AliceBobDemo.compareTriplets(list1, list2);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            /*----------------------------------------------- Problem 3------------------------------------*/
            var matirx = new int[][]
            {
                new int[] {3},
                new int[] { 11,2,4},
                new int[] { 4,5,6},
                new int[] { 10,8,12}
            };
            var dignonals1 = 0;
            var dignonals2 = 0;
            var res = 0;

            for (int row = 0; row < matirx.Length; row++)
            {

                if (row==0)
                {
                    continue;
                }
                for (int col = 0; col < matirx.Length; col++)
                {
                    if (matirx[row] == matirx[col])
                    {
                        dignonals1 += matirx[row][col];
                    }
                    if (row+col==matirx[col].Count()-1)
                    {
                        dignonals2 += matirx[row][col];
                    }
                }
            }

            if (dignonals1> dignonals2)
            {
                res = dignonals1 - dignonals2;
            }
            res = dignonals2 - dignonals1;
            Console.WriteLine("Result"+res);

            Console.ReadKey();

        }
    }
}
