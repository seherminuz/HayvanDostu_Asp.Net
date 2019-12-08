using HayvanDostu.BLL.Abstract;
using HayvanDostu.Model;
using HayvanDostu.UI.MVC.Models;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace HayvanDostu.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IPersonalService _personalService;
        ICorporateService _corporateService;

        public AccountController(IPersonalService personalService, ICorporateService corporateService)
        {
            _personalService = personalService;
            _corporateService = corporateService;
        }

        public ActionResult Login()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string Remember)
        {
            Personal personal = _personalService.GetPersonalByLogin(model.EMail, model.Password);
            Corporate corporate = _corporateService.GetCorporateByLogin(model.EMail, model.Password);

            if (personal != null)
            {
                Session["personal"] = personal;
                Session["personalID"] = personal.ID;
                if (Remember == "on")
                {
                    
                    FormsAuthentication.RedirectFromLoginPage(model.EMail, true);
                }
                else
                {
                    FormsAuthentication.RedirectFromLoginPage(model.EMail, false);
                }
                if (personal.UserRoleID == 1)
                {
                    return RedirectToAction("ListPersonal", "Admin");
                }
                else
                {
                    return RedirectToAction("Profil", "PersonalProfil", new { id = personal.ID });
                }
            }
            else if (corporate != null)
            {
                Session["corporate"] = corporate;
                return RedirectToAction("CorparateProfil", "Corporate");
            }
            else
            {
                ViewBag.Message = "!!Hatalı giriş yaptınız.Tekrar deneyin.";
            }
            return View();
        }

        public ActionResult PersonalRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonalRegister(AccountViewModel model)
        {
            try
            {
                if (model.Password != model.rePassword)
                {
                    ViewBag.Message = "Şifreler uyuşmuyor";
                }
                else
                {
                    Personal personal = new Personal();
                    personal.FirstName = model.FirstName;
                    personal.LastName = model.LastName;
                    personal.BirthDate = model.BirthDate;
                    personal.Gender = model.Gender;
                    personal.HaveAPet = model.HaveAPet;
                    personal.PetCount = model.PetCount;
                    personal.Username = model.Username;
                    personal.EMail = model.EMail;
                    personal.Password = model.Password;
                    personal.Phone = model.Phone;
                    personal.Address = model.Address;
                    personal.UserRoleID = 2;
                    personal.IsActive = false;
                    bool result = _personalService.Insert(personal);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View("Login");
        }

        public ActionResult CorporateRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CorporateRegister(CorporateViewModel model)
        {
            try
            {
                if (model.Password != model.rePassword)
                {
                    ViewBag.Message = "Şifreler uyuşmuyor";
                }
                else
                {
                    Corporate corporate = new Corporate();
                    corporate.CompanyName = model.CompanyName;
                    corporate.Username = model.Username;
                    corporate.EMail = model.EMail;
                    corporate.Password = model.Password;
                    corporate.Phone = model.Phone;
                    corporate.Address = model.Address;
                    corporate.UserRoleID = 3;
                    corporate.IsActive = false;
                    bool result = _corporateService.Insert(corporate);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View("Login");
        }

        public ActionResult LogOff()
        {
            Session["personalID"] = null;
            Session["personal"] = null;
            Session["corporate"] = null;
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


    }
}