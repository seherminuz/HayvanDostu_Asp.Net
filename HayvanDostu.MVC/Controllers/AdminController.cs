using HayvanDostu.BLL.Abstract;
using HayvanDostu.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayvanDostu.MVC.Controllers
{

    public class AdminController : Controller
    {

        IPersonalService _personalService;
        ICorporateService _corporateService;
        IPetService _petService;
        AdminModel model;
        PetListModel petModel;

        public AdminController(IPersonalService personalService, ICorporateService corporateService, IPetService petService)
        {
            _personalService = personalService;
            _corporateService = corporateService;
            _petService = petService;
            model = new AdminModel();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPassivePersonal()
        {
            model.Personals = _personalService.GetAll();
            return View(model);
        }

        public ActionResult ListActivePersonal()
        {
            model.Personals = _personalService.GetAll();
            return View(model);
        }

        public ActionResult ConfirmPersonal(int id)
        {
            model.Personal = _personalService.Get(id);
            model.Personal.IsActive = true;
            bool result = _personalService.Update(model.Personal);

            return RedirectToAction("ListActivePersonal", "Admin", model);

        }

        public ActionResult DeletePersonal(int deleteID)
        {
            _personalService.DeleteByID(deleteID);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        public ActionResult ListPet()
        {
            model.Pets = _petService.GetAll();
            return View(model);
        }

        public ActionResult DeletePet(int deleteID)
        {
            _petService.DeleteByID(deleteID);
            return Json("ok",JsonRequestBehavior.AllowGet);
        }
    }
}