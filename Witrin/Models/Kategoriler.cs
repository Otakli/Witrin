using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Kategoriler
    {
        public Kategoriler()
        {
            this.Urunlers = new List<Urunler>();
        }

        public int kat_id { get; set; }
        public int anakat_id { get; set; }
        public string kat_ad { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
