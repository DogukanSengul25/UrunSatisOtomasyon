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
    public class PersonelController : Controller
    {
        PersonelContext ctx = new PersonelContext();

        public ActionResult Index()
        {


            using (PersonelContext ctx = new PersonelContext())
            {
                PersonelViewModel pvm = new PersonelViewModel();
                pvm.Personeler = ctx.Personeler.ToList();

                return View(pvm);
            }

        }


        public ActionResult Ekle()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Ekle(Personel p)
        {

            if (ModelState.IsValid)
            {
                using (PersonelContext ctx = new PersonelContext())
                {
                    ctx.Personeler.Add(p);
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
            List<Personel> prslistesi = ctx.Personeler.ToList();
            foreach (var list in prslistesi)
            {
                liste += "<br>" + list.Ad + " " + list.Soyad + " " + list.Numara + " " + list.Tc + "<hr>";
            }
            return liste;
        }

        public ActionResult Duzenle(int? id)
        {
            using (PersonelContext ctx = new PersonelContext())
            {
                var per = ctx.Personeler.Find(id);

                return View(per);
            }
        }


        [HttpPost]
        public ActionResult Duzenle(Personel per)
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
                var per = ctx.Personeler.Find(id);
                ctx.Personeler.Remove(per);
                ctx.SaveChanges();
                return RedirectToAction("Index");

            }
        }
    }
}