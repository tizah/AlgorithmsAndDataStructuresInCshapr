using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 3, 5, 7, 19 };
            Console.WriteLine(Difference(arr));
        }

        public static int Difference(int[] a)
        {
            int maxDiff = 0;

            Array.Sort(a);

            maxDiff = a[a.Length - 1] - a[0] ;


            return maxDiff;
        }
    }
}
