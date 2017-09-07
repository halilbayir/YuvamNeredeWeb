using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuvamNerede.Model.Models.ViewModels;

namespace YuvamNerede.Web.Controllers
{
    public class AnasayfaController : SiteBaseController
    {
        
        // GET: Anasayfa
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
    }
}