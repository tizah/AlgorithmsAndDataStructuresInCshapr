﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thurs, Fri, Sat};
        static void Main(string[] args)
        {
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
            Console.WriteLine(Days.Thurs);
        }
    }
}
