using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Urunozellik
    {
        public int ozellikdetay_id { get; set; }
        public Nullable<int> ozellik_id { get; set; }
        public Nullable<int> urun_id { get; set; }
        public string deger { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual Urunozelliktanım Urunozelliktanım { get; set; }
    }
}
