using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayvanDostu.MVC.Models
{
    public class PetViewModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string Story { get; set; }
        public string Image { get; set; }

    }
}