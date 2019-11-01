using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayvanDostu.UI.MVC.Models
{
    public class CorporateViewModel
    {
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string rePassword { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int UserRoleID { get; set; }
    }
}