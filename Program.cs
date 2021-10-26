using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age))
                age--;
                Console.WriteLine("age is" + age);
            if (age<18)
            {
                Console.WriteLine(" not eligible");
            }
            else
            {
                Console.WriteLine("eligible");
            }
        

            

        }
    }
}
