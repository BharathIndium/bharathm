using System;
namespace methods
{
    class call
    {
        public void User()
        {
            string user;
            string email;
            string password;
            string number;

            string[] epma = new string[4];
            Console.WriteLine("enter your name");
            user = Console.ReadLine();
            epma[0] = user ;

            Console.WriteLine("enter your email");
            email = Console.ReadLine();
            epma[1] = email;

            Console.WriteLine("enter your password");
            password = Console.ReadLine();
            epma[2] = password;

            Console.WriteLine("enter your number");
            number = Console.ReadLine();
            epma[3] = number;
            foreach(string obj in epma)
            {
                Console.WriteLine(obj);
            }




        }
    }
}
