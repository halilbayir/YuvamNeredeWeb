using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuvamNerede.Model.Models.ORM.DBContext;

namespace YuvamNerede.Web.Controllers
{
    public class SiteBaseController : Controller
    {
        
            public YuvamNeredeDBContext db;

            public SiteBaseController ()
            {
            db = new YuvamNeredeDBContext();
            }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();   
        }
    }
    
}