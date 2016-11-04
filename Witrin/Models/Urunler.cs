using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Urunler
    {
        public Urunler()
        {
            this.Kampanyalars = new List<Kampanyalar>();
            this.Sepets = new List<Sepet>();
            this.Urunozelliks = new List<Urunozellik>();
            this.UrunSatis = new List<UrunSati>();
            this.Yorums = new List<Yorum>();
        }

        public int urun_id { get; set; }
        public string urun_ad { get; set; }
        public int kat_id { get; set; }
        public int marka_id { get; set; }
        public int urunresim_id { get; set; }
        public double urun_fiyat { get; set; }
        public int stokadet { get; set; }
        public virtual ICollection<Kampanyalar> Kampanyalars { get; set; }
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual Markalar Markalar { get; set; }
        public virtual ICollection<Sepet> Sepets { get; set; }
        public virtual Urunresimler Urunresimler { get; set; }
        public virtual ICollection<Urunozellik> Urunozelliks { get; set; }
        public virtual ICollection<UrunSati> UrunSatis { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
    }
}
