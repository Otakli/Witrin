using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Kampanyalar
    {
        public int Kampanya_id { get; set; }
        public int Urun_id { get; set; }
        public int indirimoran { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
