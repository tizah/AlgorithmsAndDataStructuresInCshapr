using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructuresInCshapr
{
    class Program
    {
        static void Main(string[] args)
        {
            FindExponent();
            BubbleSort.BubbleSort1();
            InsertionSort.InsertionSort1();
        }
        //program to find the exponent of any number by provide the number and its exponent
        public static void FindExponent()
        {
            int numBase = 2;
            int exp = 16;
            int result = 1;

            while (exp > 0)
            {
                result = result * numBase;
                exp--;
            }

            Console.WriteLine($"Result is {result}");
        }

        
    }
}
