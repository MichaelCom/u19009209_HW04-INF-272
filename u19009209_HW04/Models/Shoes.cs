using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19009209_HW04.Models
{
    public class Shoes : Clothes
    {
        public string _Type { get; set; }

        public Shoes() : base()
        {

        }

        public Shoes(string Category, string Color, string Size, int Price, int Quantity, string Type) : base(Category, Color, Size, Price,Quantity)
        {
            _Type = Type;
        }

        public override string ItemDescription()
        {
            return this._Color + " " + this._Type + " shoes.";
        }
        public override string DeliveryTime()
        {
            return "This item wil be delivered in " + Convert.ToString(Deliverydays()) + " working days.";
        }

        private int Deliverydays()
        {
            Random days = new Random();
            days.Next(0, 14);
            return days.Next();
        }

        public string Type { get { return _Type; } set { _Type = value; } }
    }
}