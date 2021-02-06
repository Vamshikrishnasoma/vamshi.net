using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnumber
{
    class factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int fact = 1;
            while(start<=num)
            {
                fact = fact * start;
                start++;
            }
            Console.WriteLine(fact);
        }

    }
}
