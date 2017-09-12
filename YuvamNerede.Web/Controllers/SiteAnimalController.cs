using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuvamNerede.Model.Models.ViewModels;
using YuvamNerede.Service.Repos;
using YuvamNerede.Web.Models.SiteDropdownModel;

namespace YuvamNerede.Web.Controllers
{
    public class SiteAnimalController : SiteBaseController
    {
        public ActionResult Index(int id)
        {
            var animal = db.Animal.FirstOrDefault(x => x.ID == id);
            AnimalSiteVM model = new AnimalSiteVM();
            model.Name= animal.Name;
            model.ID = animal.ID;
            model.GenusID = animal.GenusId;
            model.CategoryID = animal.CategoryId;
            model.Description = animal.Description;
            model.Color = animal.Color;
            model.Location = animal.Location;
            model.Image = animal.Image;
            return View(model);
        }
    }
}