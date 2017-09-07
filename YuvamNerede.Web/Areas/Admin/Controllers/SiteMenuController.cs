using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuvamNerede.Model.Models.ORM.Entity.SiteEntity;
using YuvamNerede.Model.Models.ViewModels;

namespace YuvamNerede.Web.Areas.Admin.Controllers
{
    public class SiteMenuController : BaseController
    {
      

        public ActionResult AddSiteMenu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSiteMenu(SiteMenuVM model)
        {
            SiteMenu sitemenu = new SiteMenu();
            sitemenu.Name = model.Name;
            sitemenu.Url = model.Url;
            sitemenu.CssClass = model.cssClass;
            db.SiteMenu.Add(sitemenu);
            db.SaveChanges();
            ViewBag.islemDurum = 1;
            return View();
        }
    }
}