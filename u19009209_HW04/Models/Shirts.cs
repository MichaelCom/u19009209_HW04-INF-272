using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19009209_HW04.Models
{
    public class Shirts : Clothes
    {
        public string _Cut;

        public Shirts() : base()
        {

        }

        public Shirts(string Category, string Color, string Size, int Price, int Quantity, string Cut) : base(Category, Color, Size, Price, Quantity)
        {
            _Cut = Cut;
        }

        public override string ItemDescription()
        {
            return this._Color + " " + this._Cut;
        }
        public override string DeliveryTime()
        {
            return "This item wil be delivered in "+ Convert.ToString(Deliverydays()) +" working days."; 
        }

        private int Deliverydays()
        {
            Random days = new Random();
            days.Next(0, 14);
            return days.Next();
        }

        public string Cut { get { return _Cut; } set { _Cut = value; } }
    }
}