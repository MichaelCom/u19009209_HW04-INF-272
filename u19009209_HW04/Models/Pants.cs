using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19009209_HW04.Models
{
    public class Pants : Clothes
    {
        public string _Kind { get; set; }

        public Pants() : base()
        {

        }

        public Pants(string Category, string Color, string Size,  int Price, int Quantity, string Kind) : base (Category, Color,  Size, Price, Quantity)
        {
            _Kind = Kind;
        }

        public override string ItemDescription()
        {
            return this._Color + " " + this._Kind;
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

        public string Kind { get { return _Kind; } set { _Kind = value; } }
    }
}