using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Urunresimler
    {
        public Urunresimler()
        {
            this.Urunlers = new List<Urunler>();
        }

        public int urunresim_id { get; set; }
        public string urunresim_ad { get; set; }
        public string kucukresim { get; set; }
        public string ortaresim { get; set; }
        public string buyukresim { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
