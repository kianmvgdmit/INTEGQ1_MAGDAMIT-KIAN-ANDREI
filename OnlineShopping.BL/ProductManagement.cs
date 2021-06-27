using OnlineShopping.DL;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.BL
{
    public class ProductManagement
    {
        public List<Products> ProductDetails = new List<Products>()
        {
            new Products ("Nike Air Force 1 Cactus Jack    ","$250", new DateTime(2021,6,27)),
            new Products ("Jordan 1 Mocha                  ","$350", new DateTime(2021,6,27)),
            new Products ("Nike Kobe V Bruce Lee           ","$550", new DateTime(2021,6,27)),
            new Products ("Adidas Yeezy Boost 350 V2 Zebra ","$389", new DateTime(2021,6,27)),
            new Products ("Aimé Leon Dore x New Balance 550","$429", new DateTime(2021,6,27)),
        };


        public void ProductView()
        {
            foreach (Products product in ProductDetails)
            {
                Console.WriteLine("|=================================================================================|");
                Console.WriteLine("|Shoe Brand:{0}|Price: {1}|Date: {2}", product.ShoeBrand, product.Price, product.Date);
                Console.WriteLine("|=================================================================================|");

            }
        }
        public void ProductAdd()
        {
            foreach (Products product in ProductDetails)
            {
                Console.WriteLine("Shoe Brand:{0}|Price: {1}| Date Time:{2}", product.ShoeBrand, product.Price, product.Date);
            }

            Console.WriteLine("Enter Shoe Brand: ");
            string addProduct = Console.ReadLine();
            Console.WriteLine("Enter Price:$ ");
            string addPrice = Console.ReadLine();
            DateTime addDate = DateTime.Now;


            ProductDetails.Add(new Products(addProduct, addPrice, addDate));
            Console.WriteLine("Shoe brand:{0} | Price:${1} |Date: {2}| Successfully Added", addProduct, addPrice, addDate);

            foreach (Products product in ProductDetails)
            {
                Console.WriteLine("Shoe Brand:{0}|Price: {1}| Date:{2}", product.ShoeBrand, product.Price, product.Date);
            }
        }
        public void ProductRemoved()
        {
            Console.WriteLine("Enter Index Position:");
            int indexPosition = int.Parse(Console.ReadLine());

            ProductDetails.RemoveAt(indexPosition);

            foreach (Products product in ProductDetails)
            {
                Console.WriteLine("Shirt Brand:{0}|Price: {1}| Date:{2}", product.ShoeBrand, product.Price, product.Date);
            }
        }
    }
}