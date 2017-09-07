using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YuvamNerede.Model.Models.ORM.DBContext;
using YuvamNerede.Model.Models.ORM.Entity.AdminEntity;

namespace YuvamNerede.Web.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private YuvamNeredeDBContext db = new YuvamNeredeDBContext();
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (db.AdminUser.Any(x => x.Email == model.EMail && x.Password == model.Password && x.IsDeleted == false))
                {
                    FormsAuthentication.SetAuthCookie(model.EMail, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("AdminLogin", "Login");
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}