﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            int rev = 0;
            while(num!=0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            Console.WriteLine($"reverse number is:{rev}");
            Console.ReadLine();
        }
    }
}
