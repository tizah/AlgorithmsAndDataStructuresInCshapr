using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Reversal("hello"));
        }

        public static string Reversal(string s)
        {
            //char[] cArray = s.ToCharArray();
            //string reverse = String.Empty;
            //for (int i = cArray.Length - 1; i > -1; i--)
            //{
            //    reverse += cArray[i];
            //}
            //return reverse;

            char[] cArray = s.ToCharArray();
            
            string reverse = String.Empty;
            for (int i = s.Length - 1; i >=  1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
