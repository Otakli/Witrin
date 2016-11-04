using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Urunozelliktanım
    {
        public Urunozelliktanım()
        {
            this.Urunozelliks = new List<Urunozellik>();
        }

        public int ozellik_id { get; set; }
        public string ozellik_ad { get; set; }
        public virtual ICollection<Urunozellik> Urunozelliks { get; set; }
    }
}
