using HayvanDostu.BLL.Abstract;
using HayvanDostu.Model;
using HayvanDostu.MVC.Models;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HayvanDostu.MVC.Controllers
{
    public class AccountController : Controller
    {
        IPersonalService _personalService;
        ICorporateService _corporateService;
        // GET: Account
        public AccountController(IPersonalService personalService,ICorporateService corporateService)
        {
            _personalService = personalService;
            _corporateService = corporateService;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            Personal personal = _personalService.GetPersonalByLogin(model.EMail, model.Password);
            Corporate corporate = _corporateService.GetCorporateByLogin(model.EMail, model.Password);

            if (personal != null)
            {
                Session["personalID"] = personal.ID;
                
                if (personal.UserRoleID == 1)
                {
                    return RedirectToAction("Home", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else if (corporate != null)
            {
                Session["corporateID"] = corporate.ID;
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
        public ActionResult PersonalRegister(AccountViewModel model,HttpPostedFileBase fileUpload)
        {
            try
            {
                if (model.Password != model.RePassword)
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
                    personal.PetCount = model.PetCount;
                    personal.Username = model.Username;
                    personal.EMail = model.EMail;
                    personal.Password = model.Password;
                    personal.Phone = model.Phone;
                    personal.Address = model.Address;
                    personal.UserRoleID = 2;
                    personal.IsActive = false;

                    if (fileUpload != null)
                    {
                        Image image = Image.FromStream(fileUpload.InputStream);
                        int width = Convert.ToInt32(ConfigurationManager.AppSettings["ImageWidth"].ToString());
                        int height = Convert.ToInt32(ConfigurationManager.AppSettings["ImageHeight"].ToString());

                        string name = "/Content/img" + Guid.NewGuid() + Path.GetExtension(fileUpload.FileName);

                        Bitmap bmp = new Bitmap(image, width, height);
                        bmp.Save(Server.MapPath(name));

                        model.Image = name;

                        personal.ImagePath1 = model.Image;

                    }
                    bool result = _personalService.Insert(personal);
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
            return RedirectToAction("Login");
        }
    }
}