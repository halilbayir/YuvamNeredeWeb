using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuvamNerede.Model.Models.ORM.DBContext;
using YuvamNerede.Web.Areas.Admin.Models.Attributes;

namespace YuvamNerede.Web.Areas.Admin.Controllers
{
   /* [LoginControl]*/
    public class BaseController : Controller
    {
        public YuvamNeredeDBContext db;

        public BaseController()
        {
            db = new YuvamNeredeDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

    }
}