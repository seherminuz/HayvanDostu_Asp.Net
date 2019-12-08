using HayvanDostu.BLL.Abstract;
using HayvanDostu.BLL.Concrete;
using HayvanDostu.Model;
using HayvanDostu.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayvanDostu.UI.MVC.Controllers
{
    public class AdminController : Controller
    {
        IPersonalService _personalService;
        AdminModel model;

        public AdminController(IPersonalService personalService)
        {
            _personalService = personalService;
            model = new AdminModel();

        }
        public ActionResult AdminHome()
        {
            
            
            return View();
        }
        public ActionResult ListPersonal()
        {
            
            model.Personals = _personalService.GetAll();
            return View(model);
        }

        public ActionResult DeletePersonal(int? personalID)
        {

            return View();
            
        }

        public ActionResult ConfirmPersonal()
        {
            return View();
        }
        

    }
}