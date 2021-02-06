using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnumber
{
    class perfectnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int sum = 0;
            while (start <= num)
            {
                if (num%start==0)
                    {
                    sum = sum + start;
                    }
                start++;
                }
            if(num==sum)
            {
                Console.WriteLine("perfect number");
            }
            else
            {
                Console.WriteLine("not a perfect number");
            }
        }
    }
}
