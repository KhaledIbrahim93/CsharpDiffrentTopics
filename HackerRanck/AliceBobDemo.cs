using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanck
{
   public class AliceBobDemo
    {
        public static int AliceCount { get; set; }
        public static int BobCount { get; set; }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    AliceCount++;
                }
                if (a[i] < b[i])
                {
                    BobCount++;
                }

            }
            result.Add(AliceCount);
            result.Add(BobCount);
            return result;
        }

    }
}
