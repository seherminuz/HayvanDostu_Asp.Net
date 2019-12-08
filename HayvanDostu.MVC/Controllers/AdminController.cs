using HayvanDostu.BLL.Abstract;
using HayvanDostu.Model;
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
        IMainPageOptionsService _mainPageOptionsService;
        AdminModel model;
        

        public AdminController(IPersonalService personalService, ICorporateService corporateService, IPetService petService,IMainPageOptionsService mainPageOptionsService)
        {
            _personalService = personalService;
            _corporateService = corporateService;
            _petService = petService;
            _mainPageOptionsService = mainPageOptionsService;
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

        public ActionResult AdminMainPageOptions()
        {

            var mainOptions = _mainPageOptionsService.GetAll();
            
            return View(mainOptions);
        }

        [HttpPost]
        public ActionResult AdminMainPageOptions(MainPageOptions model)
        {

            var mo = _mainPageOptionsService.Get(model.ID);
                mo.Title = model.Title;
                mo.Author = model.Author;
                mo.Address = model.Address;
                mo.Description = model.Description;
                mo.Keywords = model.Keywords;
                mo.Phone = model.Phone;
                mo.SocialLink1 = model.SocialLink1;
                mo.SocialLink2 = model.SocialLink2;
                mo.SocialLink3 = model.SocialLink3;

                 _mainPageOptionsService.Update(mo);

            return RedirectToAction("AdminMainPageOptions");
        }
    }
}