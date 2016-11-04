using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Uye
    {
        public Uye()
        {
            this.Sepets = new List<Sepet>();
            this.Siparis = new List<Sipari>();
            this.UrunSatis = new List<UrunSati>();
        }

        public System.Guid uye_id { get; set; }
        public string uye_ad { get; set; }
        public string uye_soyad { get; set; }
        public string mail { get; set; }
        public System.DateTime kayıt_tarih { get; set; }
        public int sehir_id { get; set; }
        public string cep_tel { get; set; }
        public bool kullanıcı_tip { get; set; }
        public virtual aspnet_Users aspnet_Users { get; set; }
        public virtual Sehirler Sehirler { get; set; }
        public virtual ICollection<Sepet> Sepets { get; set; }
        public virtual ICollection<Sipari> Siparis { get; set; }
        public virtual ICollection<UrunSati> UrunSatis { get; set; }
    }
}
