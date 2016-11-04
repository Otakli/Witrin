using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class UrunSati
    {
        public int urunsatis_id { get; set; }
        public int urun_id { get; set; }
        public int satis_adet { get; set; }
        public System.DateTime satis_date { get; set; }
        public System.Guid uye_id { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
