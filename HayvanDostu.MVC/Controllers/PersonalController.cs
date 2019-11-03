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