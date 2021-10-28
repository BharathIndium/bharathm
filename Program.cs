using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, temp;
            int[] arr = new int[15];

            Console.Write("Enter no of emp :");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter salarys");
            for (i = 0; i < n; i++)

            {

                arr[i] = int.Parse(Console.ReadLine());

            }

           for (i = 0; i < n; i++)

            {

                for (j = i + 1; j < n; j++)


                {
                   
                    if (arr[i] > arr[j])

                    {
                        
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                  
                }

            }
            Console.WriteLine("After Ascending Numbers ");
           
            for (i = 0; i < n; i++)
            {

                Console.WriteLine(arr[i]);
               
            }
            double highestSalary = arr.Max();

            double lowestSalary = arr.Min();

            Console.WriteLine("highestSalary is:{0}\nlowestSalary is:{1}\n",highestSalary, lowestSalary);


            Console.ReadKey();
        }
    }
}






    