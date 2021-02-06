using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnumber
{
    class rangeofnum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter range:");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
