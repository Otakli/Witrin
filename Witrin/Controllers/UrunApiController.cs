using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Witrin.Models;

namespace Witrin.Controllers
{
    public class UrunApiController : ApiController
    {
        witrinContext wc = new witrinContext();
        public IEnumerable<UrunApi> GetAllUrun()
        {   
            var list = wc.Urunlers.Select(x=> new UrunApi{
              urun_ad= x.urun_ad         
            }); 
            return list;
        }

    }
}
