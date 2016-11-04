using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Witrin.Models;

namespace Witrin.Controllers
{
    public class YonetimController : Controller
    {
       
        witrinContext wc = new witrinContext();
       

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Urunler()
        {
            var urunler = wc.Urunlers.ToList();
            return View(urunler);
        }

        public ActionResult Urunekle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Urunekle(Urunler u ,HttpPostedFileBase Resim)
        {
            u.urunresim_id = ResimKaydet(Resim,HttpContext);

            wc.Urunlers.Add(u);

            wc.SaveChanges();

            return View();
        }


        public ActionResult UrunOzelliktanımekle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult UrunOzelliktanımekle(Urunozelliktanım ur)
        {
            wc.Urunozelliktanım.Add(ur);
            wc.SaveChanges();
            return View();
        }

        public ActionResult UrunOzelliktanım()
        {
            var oztanım = wc.Urunozelliktanım.ToList();
            return View(oztanım);
        }


        public ActionResult Urunozellikleri()
        {
            var uo = wc.Urunozelliks.ToList();
            return View(uo);
        }


        public ActionResult Yeniozellikekle()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Yeniozellikekle(Urunozellik uo)
        {
            wc.Urunozelliks.Add(uo);
            wc.SaveChanges();
            return View();  
        }

    


        public ActionResult Kategoriler()
        {
            var kategoriler = wc.Kategorilers.ToList();
            return View(kategoriler);
        }


        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategoriler k)
        {
            wc.Kategorilers.Add(k);
            wc.SaveChanges();

            return View();
        }

        public ActionResult Markalar()
        {
            var markalar = wc.Markalars.ToList();
            return View(markalar);
        }

        public ActionResult MarkaEkle()
        {
            return View();
        }

        [HttpPost]
         public ActionResult MarkaEkle(Markalar m)
        {
            wc.Markalars.Add(m);
            wc.SaveChanges();
            return View();
        }

        public ActionResult UrunGuncelle(int? id)
        {
            Urunler urunler = wc.Urunlers.Find(id);
            return View(urunler);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UrunGuncelle(Urunler urun)
        {
            if (ModelState.IsValid)
            {
                wc.Entry(urun).State = EntityState.Modified;
                wc.SaveChanges();
                
            }
            return RedirectToAction("Urunler");
        }

        public static int ResimKaydet(HttpPostedFileBase Resim, HttpContextBase ctx)
        {
            witrinContext wc = new witrinContext();


            int KW = Convert.ToInt32(ConfigurationManager.AppSettings["kw"]);
            int KH = Convert.ToInt32(ConfigurationManager.AppSettings["kh"]);

            int OW = Convert.ToInt32(ConfigurationManager.AppSettings["ow"]);
            int OH = Convert.ToInt32(ConfigurationManager.AppSettings["oh"]);

            int BW = Convert.ToInt32(ConfigurationManager.AppSettings["bw"]);
            int BH = Convert.ToInt32(ConfigurationManager.AppSettings["bh"]);


            string newname = Path.GetFileNameWithoutExtension(Resim.FileName) + Guid.NewGuid() + Path.GetExtension(Resim.FileName);

            Image orjres = Image.FromStream(Resim.InputStream);
            Bitmap kr = new Bitmap(orjres, KW, KH);
            Bitmap or = new Bitmap(orjres, OW, OH);
            Bitmap br = new Bitmap(orjres, BW, BH);

            kr.Save(ctx.Server.MapPath("~/Content/Resimler/kucuk/" + newname));
            br.Save(ctx.Server.MapPath("~/Content/Resimler/buyuk/" + newname));
            or.Save(ctx.Server.MapPath("~/Content/Resimler/orta/" + newname));

            

            Urunresimler dbres = new Urunresimler();
            dbres.urunresim_ad = Resim.FileName;
            dbres.buyukresim = "/Content/Resimler/buyuk/" + newname;
            dbres.ortaresim = "/Content/Resimler/orta/" + newname;
            dbres.kucukresim = "/Content/Resimler/kucuk/" + newname;

            wc.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UrunResimler] ON");
            wc.Urunresimlers.Add(dbres);
            wc.SaveChanges();
            wc.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[UrunResimler] OFF");

            return dbres.urunresim_id;
        }

    }
}
