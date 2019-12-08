using HayvanDostu.BLL.Abstract;
using HayvanDostu.Model;
using HayvanDostu.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayvanDostu.UI.MVC.Controllers
{
    //[Authorize(Roles ="Personal")]
    [Authorize]
    public class PersonalProfilController : Controller
    {
        // GET: PersonalProfil
        IPersonalService _personalService;
        IPetService _petService;
        IPhotoService _photoService;
        PetListViewModel model;

        public PersonalProfilController(IPersonalService personalService, IPetService petService, IPhotoService photoService)
        {
            _personalService = personalService;
            _petService = petService;
            _photoService = photoService;
            model = new PetListViewModel();
        }

        public ActionResult Profil(int id)
        {
            Personal prs = _personalService.Get(id);
            return View(prs);
        }

        public ActionResult ProfilUpdate(int? id)
        {
            Personal p = null;

            if (id.HasValue)
            {
                p = _personalService.Get(id.Value);
            }

            if (p == null)
            {
                ViewBag.Check = true;
            }
            return View(p);
        }

        [HttpPost]
        public ActionResult ProfilUpdate(Personal p)
        {
            Personal original = _personalService.Get(p.ID);
            original.FirstName = p.FirstName;
            original.LastName = p.LastName;
            original.EMail = p.EMail;
            original.Phone = p.Phone;
            original.Address = p.Address;
            bool result = _personalService.Update(original);
            return View(p);
        }

        //[AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //[AllowAnonymous]
        [HttpPost]
        public ActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            Personal original = _personalService.GetPersonalByReset(model.Email,model.Username);
            original.Password = model.Password;
            bool result = _personalService.Update(original);
            return RedirectToAction("Login","Account", model);
            
        }

        public ActionResult PetProfileCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PetProfileCreate(Pet model, HttpPostedFileBase fileUpload)
        {
            Pet pet = new Pet();
            pet.Name = model.Name;
            pet.PetKind = model.PetKind;
            pet.PetType = model.PetType;
            pet.BirthDate = model.BirthDate;
            pet.Gender = model.Gender;
            pet.Story = model.Story;
            pet.Contact = model.Contact;
            int personalID = Convert.ToInt32(Session["personalID"]);
            pet.IndividualID = personalID;



            if (fileUpload != null)
            {
                Image image = Image.FromStream(fileUpload.InputStream);
                int width = Convert.ToInt32(ConfigurationManager.AppSettings["ImageWidth"].ToString());
                int height = Convert.ToInt32(ConfigurationManager.AppSettings["ImageHeight"].ToString());

                string name = "/Content/img"+ Guid.NewGuid() + Path.GetExtension(fileUpload.FileName);

                Bitmap bmp = new Bitmap(image, width, height);
                bmp.Save(Server.MapPath(name));

                model.Image = name;

                pet.Image = model.Image;
                
            }
            
            bool result = _petService.Insert(pet);
            return RedirectToAction("PetList");
        }

        public ActionResult PetList()
        {
            model.Pets = _petService.GetAll();
            return View(model);
            
        }

        public ActionResult PetProfil(int id)
        {
            Pet pet = _petService.Get(id);
            return View(pet);
            
        }

        public ActionResult MyPetList()
        {
            model.Pets = _petService.GetAll();
            return View(model);
        }

        public ActionResult PetDelete(int id)
        {
            _petService.DeleteByID(id);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }
    }
}