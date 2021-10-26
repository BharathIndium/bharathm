using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {

          
           
         
            Console.WriteLine("1.Add a detail \n2.update a detail \n3.display detail");
            Console.WriteLine("Enter the options");
            int option;
            option = Convert.ToInt32(Console.ReadLine());
       
            string name;
            int empid;
            int phoneno;
            string email;
            string experience;
            int salary;


            switch (option)
            {
            case 1:
                Console.WriteLine("Add a detail");

                    name = Console.ReadLine();
                    empid = Convert.ToInt32(Console.ReadLine());
                    phoneno = Convert.ToInt32(Console.ReadLine());
                    email = Console.ReadLine();
                    experience = Console.ReadLine();
                    salary = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("update a detail");
                    Console.WriteLine("given detail are updated");
                    break;
                case 3:
                    Console.WriteLine("emp details are:");
               
                    Console.WriteLine ("name=bharath");
                    Console.WriteLine("empid=1234");
                    Console.WriteLine("phoneno=12345467890");
                    Console.WriteLine("emai=bharathmbca@gmail.com");
                    Console.WriteLine("experience=2years");
                    Console.WriteLine("salary=100000");

                    break;
                default :
                    Console.WriteLine("out of range selection");
                    break;
            }


        }
    }
}
