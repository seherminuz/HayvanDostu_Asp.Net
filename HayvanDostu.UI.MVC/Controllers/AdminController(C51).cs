using HayvanDostu.BLL.Abstract;
using HayvanDostu.BLL.Concrete;
using HayvanDostu.Model;
using HayvanDostu.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HayvanDostu.UI.MVC.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Authorize]
    public class AdminController : Controller
    {
        IPersonalService _personalService;
        ICorporateService _corporateService;
        IPetService _petService;
        AdminModel model;


        public AdminController(IPersonalService personalService, ICorporateService corporateService, IPetService petService)
        {
            _personalService = personalService;
            model = new AdminModel();
            _corporateService = corporateService;
            _petService = petService;
        }

        public ActionResult ListPersonal()
        {
            model.Personals = _personalService.GetAll();
            return View(model);
        }

        public ActionResult DeletePersonal(int personalID)
        {
            _personalService.DeleteByID(personalID);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        public ActionResult PassiveListPersonal()
        {
            model.Personals = _personalService.GetAll();
            return View(model);
        }

        public ActionResult ConfirmPersonal(int id)
        {
            model.Personal = _personalService.Get(id);
            model.Personal.IsActive = true;
            bool result = _personalService.Update(model.Personal);

            return RedirectToAction("ListPersonal", "Admin",model);
          
        }

        public ActionResult ListCorporate()
        {
            model.Corporates = _corporateService.GetAll();
            return View(model);
        }

        public ActionResult DeleteCorporate(int corporateID)
        {
            _corporateService.DeleteByID(corporateID);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        public ActionResult PassiveListCorporate()
        {
            model.Corporates = _corporateService.GetAll();
            return View(model);
        }

        public ActionResult ConfirmCorporate(int id)
        {
            model.Corporate = _corporateService.Get(id);
            model.Corporate.IsActive = true;
            bool result = _corporateService.Update(model.Corporate);

            return RedirectToAction("ListCorporate", "Admin", model);

        }

        public ActionResult ListPet()
        {
            model.Pets = _petService.GetAll();
            return View(model);
        }

        public ActionResult DeletePet(int petID)
        {
            _petService.DeleteByID(petID);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

    }
}