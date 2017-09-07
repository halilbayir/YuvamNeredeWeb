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
              
            return View(model);
        }
    }
}