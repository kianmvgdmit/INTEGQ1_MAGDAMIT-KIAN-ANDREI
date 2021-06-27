using OnlineShopping.BL;
using System;

namespace OnlineShoppingAPP1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidity user = new UserValidity();
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("|               |Welcome to ShoeKartell !!|               |");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("|[1]LOG IN                                                |");
            Console.WriteLine("|[2]Register an Account                                   |");
            Console.WriteLine("|[3]About Us                                              |");
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("|                  |INPUT A NUMBER|                       |");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("|=========================================================|");


            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else if (userInput.Equals(3))
            {
                user.About();
            }

        }

    }
}
