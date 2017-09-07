using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuvamNerede.Model.Models.ORM.Entity.SiteEntity;
using YuvamNerede.Model.Models.ViewModels;
namespace YuvamNerede.Web.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        public ActionResult Index()
        {
            var result = db.Category.Where(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new CategoryVM()
            {
                Name = x.Name,
                ID = x.ID
            }).ToList();

            return View(result);
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.Name = model.Name;
                category.ID = model.ID;
                db.Category.Add(category);
                db.SaveChanges();
                ViewBag.islemDurum = 1;
                return View();
            }
            else
            {
                return View();
                ViewBag.islemDurum = 2;

            }

        }

        public JsonResult DeleteCategory(int id)
        {
            var result = db.Category.FirstOrDefault(x => x.ID == id);
            result.DeleteDate = DateTime.Now;
            result.IsDeleted = true;
            db.SaveChanges();

            return Json("");
        }

        public ActionResult UpdateCategory(int id)
        {
            var result = db.Category.FirstOrDefault(x => x.ID == id);
            CategoryVM model = new CategoryVM();
            model.Name = result.Name;

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                var result = db.Category.FirstOrDefault(x => x.ID == model.ID);
                result.Name = model.Name;
                db.SaveChanges();
                ViewBag.islemDurum = 1;
                return RedirectToAction("Index" );
            }
            else
            {
                ViewBag.islemDurum = 2;
                return View();
            }
         
        }
    }
}