using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int val , sum = 0;
            int rem;
            val =Convert.ToInt32(Console.ReadLine()); 
            for (int i = val; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }
            if (sum == val)
            {
                Console.Write("Armstrong Number");
            }
            else
            {
                Console.Write("Not an Armstrong Number");
            }
            Console.ReadLine();
        }
    }
}
