using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMVCAssign.Models;

namespace RestaurantMVCAssign.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            List<Restaurant>restaurants=new List<Restaurant>
            {
                new Restaurant(){RestaurantId=101, RestaurantName="Catch 35",Cusine=CusineType.French},
                new Restaurant(){RestaurantId=102, RestaurantName="Swagath",Cusine=CusineType.Indian},
                new Restaurant(){RestaurantId=103, RestaurantName="Blue Plate",Cusine=CusineType.Italian},
                new Restaurant(){RestaurantId=104, RestaurantName="Paradise",Cusine=CusineType.None},

            };
            return View(restaurants);
        }
        public ActionResult Image()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var restaurant = new List<Restaurant>
            {
                new Restaurant(){RestaurantId=101, RestaurantName="Catch 35",Cusine=CusineType.French},
                new Restaurant(){RestaurantId=102, RestaurantName="Swagath",Cusine=CusineType.Indian},
                new Restaurant(){RestaurantId=103, RestaurantName="Blue Plate",Cusine=CusineType.Italian},
                new Restaurant(){RestaurantId=104, RestaurantName="Paradise",Cusine=CusineType.None},
            };

            Restaurant reqRest = null;
            foreach (var item in restaurant)
            {
                if (item.RestaurantId == id)
                {
                    reqRest = item;

                }

            }

            return View(reqRest);
        }
    }
}