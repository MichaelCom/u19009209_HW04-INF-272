using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19009209_HW04.Models;

namespace u19009209_HW04.Controllers
{
    public class StoreController : Controller
    {
        //Shirt list
        public static List<Shirts> ShirtsDb = new List<Shirts>();
        //Pants list
        public static List<Pants> PantsDb = new List<Pants>();
        //Shoe list
        public static List<Shoes> ShoesDb = new List<Shoes>();
        private void StartingStore()
        {
            if (StoreDb.Count() == 0)
            {
                ShirtsDb.Add(new Shirts("Shirt","Black", "large", 450, 75, "Crew cut"));
                ShirtsDb.Add(new Shirts("Shirt", "Yellow", "Small", 250, 55, "V-Neck"));
                PantsDb.Add(new Pants("Pants", "Khaki", "Extra large", 750, 25, "Short")); 
                PantsDb.Add(new Pants("Pants", "Blue", "Medium", 850, 33, "Jeans"));
                ShoesDb.Add(new Shoes("Shoes", "Black", "12", 1250, 12, "Dress"));
                ShoesDb.Add(new Shoes("Shoes", "White", "10", 999, 22, "Running"));

                StoreDb.AddRange(ShirtsDb);
                StoreDb.AddRange(PantsDb);
                StoreDb.AddRange(ShoesDb);
            }
            else
            {
                StoreDb.Clear();
                StoreDb.AddRange(ShirtsDb);
                StoreDb.AddRange(PantsDb);
                StoreDb.AddRange(ShoesDb);
                return;
            }
        }

        public static List<Clothes> StoreDb = new List<Clothes>();


        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Store()
        {
            StartingStore();

            return View(StoreDb);
        }
        [HttpGet]
        public ActionResult AddShirtToStore()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddShirtToStore(Shirts data)
        {
            ShirtsDb.Add(data);
            return RedirectToAction("Store");
        }

        [HttpGet]
        public ActionResult AddPantsToStore()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addpantstostore(Pants data)
        {
            PantsDb.Add(data);
            return RedirectToAction("Store");
        }
        [HttpGet]
        public ActionResult AddShoeToStore()
        {
            return View();
        }
        public ActionResult addpantstostore(Shoes data)
        {
            ShoesDb.Add(data);
            return RedirectToAction("Store");
        }

    }
}