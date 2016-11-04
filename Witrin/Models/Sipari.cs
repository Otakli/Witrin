using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Sipari
    {
        public int siparis_id { get; set; }
        public System.Guid uye_id { get; set; }
        public double tutar { get; set; }
        public string adres { get; set; }
        public int kargo_id { get; set; }
        public string kargo_kodu { get; set; }
        public int banka_id { get; set; }
        public string sanalpos_sonuc { get; set; }
        public int odeme_id { get; set; }
        public System.DateTime siparis_tarih { get; set; }
        public string fatura_ad { get; set; }
        public string fatura_vergino { get; set; }
        public virtual Kargo Kargo { get; set; }
        public virtual Odemesecenek Odemesecenek { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
