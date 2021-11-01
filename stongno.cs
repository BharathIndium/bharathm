using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0, r, num, f, i;

            Console.Write("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());

            num = n;
            while (n > 0)
            {
                r = n % 10;
                f = 1;
                i = 1;
                while (i <= r)
                {
                    f = f * i;
                    i++;
                }
                s = s + f;
                n = n / 10;
            }

            if (s == num)
            {
                Console.WriteLine("It is a strong number:" + num);
            }
            else
            {
                Console.WriteLine("It is a not Strong number:" + num);
            }
        }
    }
}
