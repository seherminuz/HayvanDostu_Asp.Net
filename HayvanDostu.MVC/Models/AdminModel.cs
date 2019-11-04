using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayvanDostu.MVC.Models
{
    public class AdminModel
    {
        public List<Pet> Pets { get; set; }
        public List<Personal> Personals { get; set; }
        public List<Corporate> Corporates { get; set; }
        public Personal Personal { get; set; }
        public Corporate Corporate { get; set; }
        public Pet Pet { get; set; }
    }
}