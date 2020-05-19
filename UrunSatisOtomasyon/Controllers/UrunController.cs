using UrunSatisOtomasyon.DAL;
using UrunSatisOtomasyon.Models;
using UrunSatisOtomasyon.Models.ViewsModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrunSatisOtomasyon.Controllers
{
    [Authorize]
    public class UrunController : Controller
    {
        PersonelContext ctx = new PersonelContext();
        public ActionResult Index()
        {
            using (PersonelContext ctx = new PersonelContext())
            {
                UrunViewModel pvm = new UrunViewModel();
                pvm.Urunler = ctx.Urunler.ToList();

                return View(pvm);
            }

        }
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Urun p)
        {

            if (ModelState.IsValid)
            {
                using (PersonelContext ctx = new PersonelContext())
                {
                    ctx.Urunler.Add(p);
                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return RedirectToAction("Ekle");
        }
        public string Listele()
        {
            string liste = "";
            List<Urun> prslistesi = ctx.Urunler.ToList();
            foreach (var list in prslistesi)
            {
                liste += "<br>" + list.UrunMarka + " " + list.UrunModel + " " + list.UrunKategori + " " + list.UrunFiyat + " " + list.UrunKod + "<hr>";
            }
            return liste;
        }
        public ActionResult Duzenle(int? id)
        {
            using (PersonelContext ctx = new PersonelContext())
            {
                var per = ctx.Urunler.Find(id);

                return View(per);
            }
        }

        [HttpPost]
        public ActionResult Duzenle(Urun per)
        {
            using (PersonelContext ctx = new PersonelContext())
            {
                ctx.Entry(per).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
        }
        public ActionResult Sil(int? id)
        {
            using (PersonelContext ctx = new PersonelContext())
            {
                var per = ctx.Urunler.Find(id);
                ctx.Urunler.Remove(per);
                ctx.SaveChanges();
                return RedirectToAction("Index");

            }
        }
    }
}