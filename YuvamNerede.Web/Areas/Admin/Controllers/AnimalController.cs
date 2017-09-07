using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuvamNerede.Model.Models.ORM.Entity.SiteEntity;
using YuvamNerede.Model.Models.ViewModels;
using YuvamNerede.Service.Repos;
using YuvamNerede.Web.Models.SiteDropdownModel;

namespace YuvamNerede.Web.Areas.Admin.Controllers
{
    public class AnimalController : BaseController
    {
        public ActionResult Index()
        {
            var result = db.Animal.Where(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new AnimalVM()
            {
                ID = x.ID,
                CategoryName = x.Category.Name,
                GenusName = x.Genus.Name,
                Name = x.Name,
                Age = x.Age,
                Description = x.Description,
                Location = x.Location,
                Color = x.Color,
            }).ToList();
            
            return View(result);
        }
        public ActionResult AddAnimal()
        {
            
            AnimalSiteVM animal = new AnimalSiteVM();
            animal.drpCategories = db.Category.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.ID.ToString()
            }).ToList();
            animal.drpGenus = db.Genus.Select(x => new SelectListItem()
            {
                Text=x.Name,
                Value=x.ID.ToString()
            }).ToList();
            return View(animal);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddAnimal(AnimalSiteVM model)
        {
            if (ModelState.IsValid)
            {
                string filename = "";
                foreach (string name in Request.Files)
                {
                    model.ImagePath = Request.Files[name];
                    string ext = Path.GetExtension(Request.Files[name].FileName);
                    if (ext == ".jpg" || ext == ".jpeg" || ext == ".png")
                    {
                        string uniqnumber = Guid.NewGuid().ToString();
                        filename = uniqnumber + model.ImagePath.FileName;
                        model.ImagePath.SaveAs(Server.MapPath("~/Areas/Admin/Content/Site/images/blogpost/" + filename));
                    }
                }
                Animal animal = new Animal();
                animal.ID = model.ID;
                animal.CategoryId = model.CategoryID;
                animal.Name = model.Name;
                animal.Description = model.Description;
                animal.Location = model.Location;
                animal.Age = model.Age;
                animal.Color = model.Color;
                animal.Image = filename;
                animal.GenusId = model.GenusID;
                db.Animal.Add(animal);
                db.SaveChanges();
                ViewBag.islemDurum = 1;
                return View();
            }
            else
            {
                ViewBag.islemDurum = 2;
                return View();
            }
        
        }
        public ActionResult UpdateAnimal(int id)
        {
            var result = db.Animal.FirstOrDefault(x => x.ID == id);
            AnimalVM animal = new AnimalVM();
            animal.Name = result.Name;
            animal.ID = result.ID;
            animal.Age = result.Age;
            animal.Color = result.Color;
            animal.Location = result.Location;
            animal.GenusName = AnimalRepo.AnimalGenusName(result.GenusId);
            animal.CategoryName = AnimalRepo.AnimalCategoryName(result.CategoryId);
            return View(animal);
        }

        [HttpPost]
        public ActionResult UpdateAnimal(AnimalVM model)
        {
            if (ModelState.IsValid)
            {
                var result = db.Animal.FirstOrDefault(x => x.ID == model.ID);
                result.Name = model.Name;
                result.Description = model.Description;
                result.Color = model.Color;
                result.Location = model.Location;
                result.Age = model.Age;
                result.ID = model.ID;
                result.GenusId = AnimalRepo.AnimalGenus(model.GenusName);
                result.CategoryId = AnimalRepo.AnimalCategory(model.CategoryName);
                ViewBag.islemDurum = 1;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.islemDurum = 2;
                return View();
            }
        }
        public JsonResult DeleteAnimal(int id)
        {
            var result = db.Animal.FirstOrDefault(x => x.ID == id);
            result.DeleteDate = DateTime.Now;
            result.IsDeleted = true;
            db.SaveChanges();

            return Json("");
        }

    }
}