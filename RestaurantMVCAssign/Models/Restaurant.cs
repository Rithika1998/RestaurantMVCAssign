using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMVCAssign.Models
{
    public enum CusineType
    {
        None,
        Italian,
        French,
        Indian
    }

    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public CusineType Cusine { get; set; }
    }
}