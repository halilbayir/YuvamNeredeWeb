using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuvamNerede.Model.Models.ORM.Entity.SiteEntity;
using YuvamNerede.Model.Models.ViewModels;

namespace YuvamNerede.Web.Areas.Admin.Controllers
{
    public class GenusController : BaseController
    {
     
        public ActionResult Index()
        {
            var result = db.Genus.Where(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new GenusVM()
            {
                Name = x.Name,
                ID = x.ID,
                CategoryName=x.Category.Name
            }).ToList();

            return View(result);
        }
        public ActionResult AddGenus()
        {
            return View();
        }

        public void AddorUpdateGenus(int id)
        {
            var result = db.Genus.FirstOrDefault(x => x.ID == id);

        }

        [HttpPost]
        public ActionResult AddGenus(GenusVM model)
        {
            if (ModelState.IsValid)
            {
                Genus genus = new Genus();
                genus.Name = model.Name;
                genus.IsDeleted = false;
                
                db.Genus.Add(genus);
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

        public ActionResult UpdateGenus(int id)
        {
            var result = db.Genus.FirstOrDefault(x => x.ID == id);
            GenusVM genus = new GenusVM();
            genus.Name = result.Name;
            return View(genus);
        }

        [HttpPost]
        public ActionResult UpdateGenus(GenusVM model)
        {
            if (ModelState.IsValid)
            {
                var result = db.Genus.FirstOrDefault(x => x.ID == model.ID);
                result.Name = model.Name;
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
        public JsonResult DeleteGenus(int id)
        {
            var result = db.Genus.FirstOrDefault(x => x.ID == id);
            result.DeleteDate = DateTime.Now;
            result.IsDeleted = true;
            db.SaveChanges();

            return Json("");
        }

    }
  

}