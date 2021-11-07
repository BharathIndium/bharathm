using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB
{
    class Program
    {
        static void Main(string[] args)
        {
                joob[] j1;
                int count = int.Parse(Console.ReadLine());
                j1 = new joob[count];
                for (int i = 0; i < count; i++)
                {
                    string empname;
                    string location;
                    int exp;
                    double sal;

                Console.WriteLine("Enter the Empname");
                    empname = Console.ReadLine();
                    Console.WriteLine("Enter the Location:");
                    location = Console.ReadLine();
                    Console.WriteLine("Enter the Minimum Experience");
                    exp = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Salary");
                    sal = Convert.ToInt64(Console.ReadLine());
                    joob j2 = new joob( empname, location, exp, sal);

                }
                salary salary = new salary();
                Array.Sort(j1, salary);
                foreach (var item in j1)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.Read();
            }

           // public int CompareTo(object sal)
           // {
            //    throw new NotImplementedException();
            }
        }
    //}

