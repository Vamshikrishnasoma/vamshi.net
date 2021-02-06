using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnumber
{
    class strongnumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number :");
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            int sum = 0;
          
         
            while(num!=0)
            {
                int fact = 1;
                int start = 1;
                int digit = num % 10;
                while (start<=digit)
                {
                    fact = fact * start;
                    start++;
                }
                num = num / 10;
                sum = sum + fact;
            }
            Console.WriteLine(sum);
            if (copy == sum)
            {
                Console.WriteLine($"{copy} is strong number");
            }
            else
            {
                Console.WriteLine($"{copy} is not a strong number");
            }
        }
    }
}
