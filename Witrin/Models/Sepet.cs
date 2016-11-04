using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Sepet
    {
        public int sepet_id { get; set; }
        public System.Guid uye_id { get; set; }
        public int urun_id { get; set; }
        public double urun_fiyat { get; set; }
        public int urun_adet { get; set; }
        public System.DateTime sepet_tarih { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
