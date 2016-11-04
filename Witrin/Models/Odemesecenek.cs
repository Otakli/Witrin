using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Odemesecenek
    {
        public Odemesecenek()
        {
            this.Siparis = new List<Sipari>();
        }

        public int odeme_id { get; set; }
        public string odeme_tip { get; set; }
        public virtual ICollection<Sipari> Siparis { get; set; }
    }
}
