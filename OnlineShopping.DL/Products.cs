using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.DL
{
    public class Products
    {
        public string shoeBrand;
        private string price;
        private DateTime date;

        public Products(string shoeBrand, string price, DateTime date)
        {
            this.shoeBrand = shoeBrand;
            this.price = price;
            this.date = date;


        }


        public string ShoeBrand
        {
            get { return shoeBrand; }
            set { shoeBrand = value; }
        }


        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


    }
}