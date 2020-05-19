using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UrunSatisOtomasyon.DAL;
using UrunSatisOtomasyon.Models;

namespace UrunSatisOtomasyon.Areas.Admin.Controllers
{
    [AllowAnonymous]
    public class GirisController:Controller
    {
        PersonelContext ctx = new PersonelContext();

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            var kul = ctx.Kullanicilar.FirstOrDefault(x => x.Ad == kullanici.Ad && x.Sifre == kullanici.Sifre);
            if (kul != null)
            {
                FormsAuthentication.SetAuthCookie(kul.Ad, false);
                return RedirectToAction("Index", "Personel", new { area=""});
            }
            else
            {
                return View();

            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return View("Login");
        }
    }
}