using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_th_Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 3, 5, 7, 19 };
            int k = 2;
            Console.WriteLine("K'th smallest element is " +
                                kthSmallest(arr, k));
        }

        // Function to return k'th smallest 
        // element in a given array
        public static int kthSmallest(int[] arr,
                                             int k)
        {
            // Sort the given array
            Array.Sort(arr);

            // Return k'th element in 
            // the sorted array
            return arr[k - 1];
        }
    }
}
