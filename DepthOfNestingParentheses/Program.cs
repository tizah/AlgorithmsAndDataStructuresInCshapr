using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthOfNestingParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "( ((X)) (((Y))) )";
            Console.WriteLine(Parentheses(s));
          //  return 0;
        }
        public static int Parentheses(string S)
        {
            int current_max = 0; // current count
            int max = 0;    // overall maximum count
            int n = S.Length;

            // Traverse the input string
            for (int i = 0; i < n; i++)
            {
                if (S[i] == '(')
                {
                    current_max++;

                    // update max if required
                    if (current_max > max)
                        max = current_max;
                }
                else if (S[i] == ')')
                {
                    if (current_max > 0)
                        current_max--;
                    else
                        return -1;
                }
            }

            // finally check for unbalanced string
            if (current_max != 0)
                return -1;

            return max;
        }
    }
}
