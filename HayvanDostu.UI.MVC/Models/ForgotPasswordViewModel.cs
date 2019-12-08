using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayvanDostu.UI.MVC.Models
{
    public class ForgotPasswordViewModel
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
       
    }
}