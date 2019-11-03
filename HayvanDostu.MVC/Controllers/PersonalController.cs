using HayvanDostu.BLL.Abstract;
using HayvanDostu.MVC.Models;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.Configuration;
using System.IO;

namespace HayvanDostu.MVC.Controllers
{
    [Authorize]
    public class PersonalController : Controller
    {
        // GET: Personal
        IPersonalService _personalService;
        IPetService _petService;
        IPhotoService _photoService;
        PetListModel model;

        public PersonalController(IPersonalService personalService, IPetService petService, IPhotoService photoService)
        {
            _personalService = personalService;
            _petService = petService;
            _photoService = photoService;
            model = new PetListModel();
        }

        public ActionResult PetList ()
        {
            model.Pets = _petService.GetAll();
            int id = Convert.ToInt32(Session["personalID"]);
            return View(model);
        }

        public ActionResult PetProfil(int id)
        {
            Pet pet = _petService.Get(id);
            return View(pet);

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

                string name = "/Content/img" + Guid.NewGuid() + Path.GetExtension(fileUpload.FileName);

                Bitmap bmp = new Bitmap(image, width, height);
                bmp.Save(Server.MapPath(name));

                model.Image = name;

                pet.Image = model.Image;

            }

            bool result = _petService.Insert(pet);
            return RedirectToAction("PetList");
        }

        public ActionResult Profil(int id)
        {
            Personal prs = _personalService.Get(id);
            return View(prs);
            
        }

        public ActionResult PetProfileUpdate(int? id)
        {
            Pet pet = null;
            if (id.HasValue)
            {
                pet = _petService.Get(id.Value);
            }

            if (pet == null)
            {
                ViewBag.Check = true;
            }

            return View(pet);
        }

        [HttpPost]
        public ActionResult PetProfileUpdate(Pet pet,HttpPostedFileBase fileUpload)
        {
            Pet original = _petService.Get(pet.ID);
            original.Name = pet.Name;
            original.BirthDate = pet.BirthDate;
            original.Gender = pet.Gender;
            original.PetKind = pet.PetKind;
            original.PetType = pet.PetType;
            original.Story = pet.Story;
            if (fileUpload != null)
            {
                Image image = Image.FromStream(fileUpload.InputStream);
                int width = Convert.ToInt32(ConfigurationManager.AppSettings["ImageWidth"].ToString());
                int height = Convert.ToInt32(ConfigurationManager.AppSettings["ImageHeight"].ToString());

                string name = "/Content/img" + Guid.NewGuid() + Path.GetExtension(fileUpload.FileName);

                Bitmap bmp = new Bitmap(image, width, height);
                bmp.Save(Server.MapPath(name));

                pet.Image= name;

                original.Image = pet.Image;

            }
            bool result = _petService.Update(original);
            return RedirectToAction("PetProfil", "Personal", new { id = pet.ID });

        }

        public ActionResult ProfilUpdate(int? id)
        {
            Personal personal = null;

            if (id.HasValue)
            {
                personal = _personalService.Get(id.Value);
            }

            if (personal == null)
            {
                ViewBag.Check = true;
            }
            return View(personal);
        }

        [HttpPost]
        public ActionResult ProfilUpdate(Personal personal,HttpPostedFileBase fileUpload)
        {
            Personal original = _personalService.Get(personal.ID);
            original.FirstName = personal.FirstName;
            original.LastName = personal.LastName;
            original.EMail = personal.EMail;
            original.Phone = personal.Phone;
            original.Address = personal.Address;
            if (fileUpload != null)
            {
                Image image = Image.FromStream(fileUpload.InputStream);
                int width = Convert.ToInt32(ConfigurationManager.AppSettings["ImageWidth"].ToString());
                int height = Convert.ToInt32(ConfigurationManager.AppSettings["ImageHeight"].ToString());

                string name = "/Content/img" + Guid.NewGuid() + Path.GetExtension(fileUpload.FileName);

                Bitmap bmp = new Bitmap(image, width, height);
                bmp.Save(Server.MapPath(name));

                personal.ImagePath1 = name;

                original.ImagePath1 = personal.ImagePath1;

            }
            bool result = _personalService.Update(original);
            return RedirectToAction("Profil","Personal", new { id = personal.ID});

        }

        public ActionResult MyPetList()
        {
            model.Pets = _petService.GetAll();
            return View(model);
        }

        public ActionResult Header()
        {

            return PartialView("_Header");
        }

        public ActionResult Footer()
        {
            return PartialView("_Footer");
        }
    }
}