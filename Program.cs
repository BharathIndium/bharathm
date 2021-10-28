using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraytask1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] accdet;
            int emp, acc;
            Console.WriteLine("ENTER THE NUMBER OF EMPLOYEES ");
            emp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE NUMBER OF ACCOUNTS OF EMPLOYEES");
            acc = Convert.ToInt32(Console.ReadLine());

            accdet = new int[emp, acc];

            for (int i = 0; i < emp; i++)
            {
                int dec = 0;
                Console.WriteLine("ENTER CUSTOMER NAME");
                string name = Console.ReadLine();

                for (int j = 0; j < acc; j++)
                {


                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("ENTER 1 ACCOUNT BALANCE");
                            break;
                        case 2:
                            Console.WriteLine("ENTER 2 ACCOUNT BALANCE");
                            break;
                        case 3:
                            Console.WriteLine("ENTER 3 ACCOUNT BALANCE");
                            break;

                    }


                    dec = dec + Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine(name + "  Total balance   :" + dec);
            }


        }
    }
}
    
        