using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Sehirler
    {
        public Sehirler()
        {
            this.Uyes = new List<Uye>();
        }

        public int sehir_id { get; set; }
        public string sehir_ad { get; set; }
        public virtual ICollection<Uye> Uyes { get; set; }
    }
}
