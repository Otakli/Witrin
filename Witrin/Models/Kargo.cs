using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Kargo
    {
        public Kargo()
        {
            this.Siparis = new List<Sipari>();
        }

        public int Kargo_id { get; set; }
        public string Firma_ad { get; set; }
        public virtual ICollection<Sipari> Siparis { get; set; }
    }
}
