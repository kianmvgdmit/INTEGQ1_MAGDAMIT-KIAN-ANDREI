using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.BL
{
    public class UserInventory
    {
        public void Index()
        {
            ProductManagement productServices = new ProductManagement();

        START:
            Console.WriteLine("|=========================================================|");
            Console.WriteLine("|[1] Browse Shoes                                         |");
            Console.WriteLine("|[2] Consignment                                          |");
            Console.WriteLine("|[3] Removed Availability                                 |");
            Console.WriteLine("|[4] EXIT                                                 |");
            Console.WriteLine("|=========================================================|");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    productServices.ProductView();
                    goto START;
                case 2:
                    productServices.ProductAdd();
                    goto START;
                case 3:
                    productServices.ProductRemoved();
                    goto START;

                default:
                    break;
            }

        }
    }
}