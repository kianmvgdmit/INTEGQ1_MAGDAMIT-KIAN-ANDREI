using OnlineShopping.DL;
using System;
using System.Collections.Generic;
namespace OnlineShopping.BL
{
    public class UserValidity
    {
        public List<User> UserCredentials = new List<User>()
        {
            new User("Kian","Magdamit")
        };

        public void LogIn()
        {
            UserInventory index = new UserInventory();
            bool successful = false;
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("|Enter your Username:                                     |");
            string userName = Console.ReadLine();
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("Enter your Password:                                      |");
            string passWord = Console.ReadLine();

            foreach (User user in UserCredentials)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("Log in Successfully !!!");
                    successful = true;
                    index.Index();
                }
            }
            if (!successful)
            {
                Console.WriteLine("INVALID INPUT !!!");
            }
        }
        public void Register()
        {
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("Enter Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("Enter Password: ");
            string passWord = Console.ReadLine();

            UserCredentials.Add(new User(userName, passWord));
            Console.WriteLine("Registered Successfully!                                   ");

            foreach (User user in UserCredentials)
            {
                Console.WriteLine("Username:{0}, Passw:{1}", user.UserName, user.PassWord);
            }

        }
        public void About() 
        {
            Console.WriteLine("|=================================================================================================|");
            Console.WriteLine("|Our mission is to provide access to the world’s most coveted items in the smartest way possible. |");
            Console.WriteLine("|Buy and sell the hottest sneakers.Our real-time marketplace works just like the stock market     |");                                                                                                        
            Console.WriteLine("|Allowing you to buy and sell the most coveted items at their true market price.                  |");
            Console.WriteLine("|=================================================================================================|");                                                                                                                                   
        }    
    }
}