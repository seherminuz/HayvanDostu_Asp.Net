using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayvanDostu.UI.MVC.Models
{
    public class PetListViewModel
    {
        public List<Pet> Pets { get; set; }
        public Pet Pet { get; set; }
        public List<Personal> Personals { get; set; }
        public Personal Personal { get; set; }
    }
}