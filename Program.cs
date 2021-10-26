using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
         static  void cal()
        {
            Console.Write("------------");
            Console.Write("calculator program");
            Console.Write("------------");

        }
        public static void display()
        {
            Console.WriteLine("enter an option");
            Console.WriteLine("+Add");
            Console.WriteLine("-Sub");
            Console.WriteLine("*Multi");
            Console.WriteLine("/Div");
            Console.Write("Enter an option");
        }
        public static void bye()
        {
            Console.WriteLine("bye");
        }
     
        static void Main(string[] args)
        {
                
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                cal();
                Console.WriteLine();


                Console.WriteLine("Enter the number 1:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the number 2:");
                num2 = Convert.ToDouble(Console.ReadLine());



                display();
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("your result:" + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("your result:" + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("your result:" + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("your result:{num1}/{num2}=" + result);
                        break;

                    default:
                        Console.Write("That was not an option");
                        break;


                }
                Console.WriteLine("would you like to continue? (Yes=y,No=N)_:");
            } while (Console.ReadLine().ToUpper() == "y");
          
            bye();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
    

    
    

