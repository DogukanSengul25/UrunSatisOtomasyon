using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrunSatisOtomasyon.DAL;
using UrunSatisOtomasyon.Models;

namespace UrunSatisOtomasyon.Areas.Admin.Controllers
{
    public class KullaniciController:Controller
    {
        PersonelContext ctx = new PersonelContext();
        public ActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(Kullanici klc)
        {
            if (ModelState.IsValid)
            {
                ctx.Kullanicilar.Add(klc);
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Login", "Giris");
                }
            }
            return View();
        }
    }
}