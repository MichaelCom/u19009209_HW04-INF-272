using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19009209_HW04.Models
{
    public abstract class Clothes
    {
        public string _Category;
        public string _Color;
        public string _Size;
        public int _Price;
        public int _Quantity;
        public int _ID;

        public Clothes()
        {

        }

        public Clothes(string Category, string Color, string Size, int Price, int Quantity)
        {
            _Category = Category;
            _Color = Color;
            _Size = Size;
            _Price = Price;
            _Quantity = Quantity;
        }

        public abstract string ItemDescription();
        public abstract string DeliveryTime();

        public string Category { get { return _Category; } set { _Category = value; } }
        public string Color { get { return _Color; } set { _Color = value; } }
        public string Size { get { return _Size; } set { _Size = value; } }
        public int Price { get { return _Price; } set { _Price = value; } }
        public int Quantity { get { return _Quantity; } set { _Quantity = value; } }

    }
}