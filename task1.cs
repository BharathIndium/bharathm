using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int empid;
            int phoneno;
         
            string email;
            int salary;
            name = Console.ReadLine();
            empid = Convert.ToInt32(Console.ReadLine());
            phoneno = Convert.ToInt32(Console.ReadLine());
            email = Console.ReadLine();


            DateTime doj = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int ex = today.Year - doj.Year;
            if (doj > today.AddYears(-ex))
                Console.WriteLine(" experience is" +ex);
           
           
            salary = Convert.ToInt32(Console.ReadLine());
            salary *= 12;

            Console.WriteLine("emp details are:");
            Console.WriteLine("name is"  + name);
         
            //Console.WriteLine("experience is" +experience);
            Console.WriteLine("annualsalary is"  + salary);
            
        }
    }
}
