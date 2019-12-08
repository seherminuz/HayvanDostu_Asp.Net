using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayvanDostu.UI.MVC.Models
{
    public class AccountViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public bool HaveAPet { get; set; }
        public int PetCount { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string rePassword { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int UserRoleID { get; set; }
    }
}