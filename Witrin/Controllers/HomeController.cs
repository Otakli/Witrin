using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Witrin.Models;

namespace Witrin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        witrinContext wc = new witrinContext();
        public ActionResult Index()
        {
            ViewBag.kullanici = Session["Uye"];
            return View();
        }

        public ActionResult CıkısYap()
        {
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }



        public ActionResult KategoriGetir()
        {
            var k = wc.Kategorilers.ToList();
            return View(k);
        }
        public ActionResult YeniUrunler()
        {
            var k =  wc.Urunlers.OrderByDescending(x => x.urun_id).Take(6);
            return View(k);
        }

        public ActionResult TelevizyonYeniUrun()
        {

            if (wc.Urunlers.Where(x => x.kat_id == 1).Count()<6)
            {
                var yenitelevizyonlar = wc.Urunlers.OrderByDescending(x => x.kat_id == 1).Take( wc.Urunlers.Where(x => x.kat_id == 1).Count());
                return View(yenitelevizyonlar);
            }
             else
            {
                   var yenitelevizyonlar = wc.Urunlers.OrderByDescending(x => x.kat_id == 1).Take(6);
                return View(yenitelevizyonlar);
            }
        }

        public ActionResult TelefonYeniUrun()
        {

            if (wc.Urunlers.Where(x => x.kat_id == 28).Count() < 6)
            {
                var yenitel = wc.Urunlers.OrderByDescending(x => x.kat_id == 28).Take(wc.Urunlers.Where(x => x.kat_id == 28).Count());
                return View(yenitel);
            }
            else
            {
                var yenitel = wc.Urunlers.OrderByDescending(x => x.kat_id == 28).Take(6);
                return View(yenitel);
            }
        }


        public ActionResult BilgisayarYeniUrun()
        {

            if (wc.Urunlers.Where(x => x.kat_id == 35).Count() < 6)
            {
                var yenitelevizyonlar = wc.Urunlers.OrderByDescending(x => x.kat_id == 35).Take(wc.Urunlers.Where(x => x.kat_id == 35).Count());
                return View(yenitelevizyonlar);
            }
            else
            {
                var yenitelevizyonlar = wc.Urunlers.OrderByDescending(x => x.kat_id == 35).Take(6);
                return View(yenitelevizyonlar);
            }
        }

        public ActionResult BeyazEsyaYeniUrun()
        {

            if (wc.Urunlers.Where(x => x.kat_id == 16).Count() < 6)
            {
                var yenitelevizyonlar = wc.Urunlers.OrderByDescending(x => x.kat_id == 16).Take(wc.Urunlers.Where(x => x.kat_id == 16).Count());
                return View(yenitelevizyonlar);
            }
            else
            {
                var yenitelevizyonlar = wc.Urunlers.OrderByDescending(x => x.kat_id == 16).Take(6);
                return View(yenitelevizyonlar);
            }
        }

        
        public ActionResult HaftanınUrunleri()
        {
          var  indirimliler = wc.Kampanyalars.ToList();
          ViewBag.birinci = wc.Kampanyalars.OrderByDescending(X=>X.indirimoran).ToList().Take(3);
          ViewBag.ikinci = wc.Kampanyalars.OrderByDescending(x=>x.indirimoran).ToList().Skip(3); 
          return View(indirimliler);
        }


        public ActionResult SepetUrunArttır(int id)
        {
            Sepet sepete = wc.Sepets.FirstOrDefault(x => x.sepet_id== id);
            sepete.urun_adet = sepete.urun_adet + 1;
            wc.Entry(sepete).State = EntityState.Modified;
            wc.SaveChanges();
            return RedirectToAction("Sepetim", "Home");
        }

        public ActionResult SepetUrunAzalt(int id)
        {
            Sepet sepete = wc.Sepets.First(x => (x.sepet_id == id));
            sepete.urun_adet = sepete.urun_adet - 1;
            wc.Entry(sepete).State = EntityState.Modified;
            wc.SaveChanges();
            return RedirectToAction("Sepetim","Home");
        }


        public ActionResult Sepet(int id,int fiyat)
        {
            Sepet sepet = new Sepet();
            
            if (Session["Uye"] != null)
            {
                 ViewBag.uye= Session["Uye"];
                 var uye_id = ViewBag.uye.uye_id;
                 Guid uyeid = ViewBag.uye.uye_id;

                sepet.uye_id = uye_id;
                sepet.sepet_tarih = DateTime.Now;
                sepet.urun_fiyat = fiyat;

                if (wc.Sepets.FirstOrDefault(x => (x.uye_id == uyeid) & (x.urun_id == id)) != null)
                {
                   
                Sepet sepete =  wc.Sepets.First(x => (x.uye_id == uyeid) & (x.urun_id == id));
                sepete.urun_adet = sepete.urun_adet + 1;
                wc.Entry(sepete).State = EntityState.Modified;
                wc.SaveChanges();
                     
                }
                else
                {
                    sepet.uye_id = uye_id;
                    sepet.sepet_tarih = DateTime.Now;
                    sepet.urun_fiyat = fiyat;
                    sepet.urun_adet = 1;
                    sepet.urun_id = id;
                    wc.Sepets.Add(sepet);
                    wc.SaveChanges();
                }
               
            }

            else
            {
             return RedirectToAction("KayıtOl", "Login");
            }

            return RedirectToAction("Sepettekiler");
        }



   

        public ActionResult Sepettekiler(){

        if(Session["Uye"]!= null){

            ViewBag.uye = Session["Uye"];
            Guid uye = ViewBag.uye.uye_id;


           

            if (wc.Sepets.Select(item => item.uye_id.Equals(uye))!=null)
            {
                int kacurun = wc.Sepets.Where(x => x.uye_id == uye).Sum(x => x.urun_adet);
                double kacfiyat = wc.Sepets.Where(x => x.uye_id == uye).Sum(x => (x.urun_adet) * (x.urun_fiyat));

                TempData["Fiyat"] = kacfiyat;
                TempData["Urun"] = kacurun;            
            }

            else
            {
                int kacurun = 0;
                double kacfiyat = 0;
                TempData["Fiyat"] = kacfiyat;
                TempData["Urun"] = kacurun;
            }
                
         }

        return RedirectToAction("Index");
       }

        public ActionResult Sepetim()
        {

            if (Session["Uye"] != null)
            {
                ViewBag.uye = Session["Uye"];
                Guid uye = ViewBag.uye.uye_id;
           
                  if (wc.Sepets.Select(item => item.uye_id.Equals(uye)) == null)
                  {
                    ViewBag.mesaj = "Sepetiniz Boş";
                  }
                    
                  else
                   {
                   ViewBag.uyeurun = wc.Sepets.Where(x => x.uye_id == uye);
                   ViewData["uyeurun"] = wc.Sepets.Where(x => x.uye_id == uye);
                   }

                  return View();
            }

          
            else
            {
                return RedirectToAction("GirisYap","Login");
            }
           
          
        }

        public ActionResult SepetUrunSil(int id)
        {
            Sepet s = wc.Sepets.FirstOrDefault(x => x.sepet_id == id);
            wc.Sepets.Remove(s);
            wc.SaveChanges();
            return RedirectToAction("Sepetim","Home");
        }

  

        public ActionResult EnCokSatılanUrunler()
        {
            return View();
        }

    }
}
