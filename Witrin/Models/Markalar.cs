using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Markalar
    {
        public Markalar()
        {
            this.Urunlers = new List<Urunler>();
        }

        public int marka_id { get; set; }
        public string marka_ad { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
