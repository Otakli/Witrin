using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Witrin.Models;

namespace Witrin.Controllers
{
    public class LoginController : Controller
    {
        witrinContext wc = new witrinContext();

        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(string nick,string parola)
        {

            if (Membership.ValidateUser(nick, parola))
            {
                FormsAuthentication.RedirectFromLoginPage(nick,true);
                Guid id = (Guid) Membership.GetUser(nick).ProviderUserKey;
                Session["Uye"] = wc.Uyes.FirstOrDefault(x => x.uye_id == id);    
                return RedirectToAction("Sepettekiler","Home");
            }
            else
            {
                ViewBag.Mesaj = "Kullanıcı adı veya Parola yanlış";
                return View();
            }

            
        }

        public ActionResult KayıtOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KayıtOl(Uye uye,string nick , string parola)
        {
            MembershipUser user = Membership.CreateUser(nick , parola);
            uye.uye_id =(Guid) user.ProviderUserKey;
            uye.kayıt_tarih = DateTime.Now;
            uye.kullanıcı_tip = true;
            wc.Uyes.Add(uye);
            wc.SaveChanges();
            FormsAuthentication.RedirectFromLoginPage(nick, true);      
            Session["Uye"] = uye;
            return RedirectToAction("Index","Home");
        }
    }
}
