using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            string student_details;
            Console.WriteLine("ENTER PARTICIPENT DETAILS");
            student_details = Console.ReadLine();
            string[] d = student_details.Split(',');

            foreach (string split in d)
            {
                Console.WriteLine(split);
            }
        }
    }
}
