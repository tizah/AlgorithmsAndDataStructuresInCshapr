using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayAverageOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[2];
            a[0] = 2;
            a[1] = 3;
    


            Console.WriteLine(arrayAverage(a));
            //Average("List One", -2, 4, -1, 6);
            //Average("List Two", 5, 10, 15, 20, 25, 1230);

        }

        static int arrayAverage(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            if (sum >= 0)
            {
                sum = ((sum * 2 / a.Length + 1)) >> 1;
            }
            else
            {
                sum = (((sum * 2 - a.Length + 1) / a.Length + 1)) >> 1;
            }

            return sum;
                }
            

        private static int Average(string title, params int[] values)
        {
            double sum = 0;
            int total = 0;
           // string a  = string.Empty;

            for (int i = 0; i < values.Length; i++)
            {
         
             sum += values[i];
        
               //  System.Console.Write(values[i] + ", ");
            }


 
              var b  = (sum / values.Length);

            string s = b.ToString();
            string[] parts = s.Split('.');
            int i1 = int.Parse(parts[0]);
            int i2 = int.Parse(parts[1]);
            // b = Math.Round(b);
            //b.ToString();
            if (i2 >= 5)
            {
                i1++;
            }

            return i1;
               //     return total ;
        }
        // int[] a = new int[4];

        ///// int[] firstArray = new int[4];
        // a[0] = 1;
        // a[1] = 3;
        // a[2] = 1;
        // a[3] = 1;
        // float total = 0;


        // //int[] array = new int[4];



        // for (int i = 0; i < a.Length; i++)
        // {
        //     total += a[i];
        // }
        // total = (total / a.Length);
        //total = (float)Math.Ceiling(total);
        // Console.WriteLine(total);
        //}

    }
}
