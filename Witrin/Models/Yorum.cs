using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Yorum
    {
        public int Yorum_id { get; set; }
        public int Urun_id { get; set; }
        public string icerik { get; set; }
        public System.DateTime eklenme_tarih { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
