using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Bankalar
    {
        public Bankalar()
        {
            this.Taksitlers = new List<Taksitler>();
        }

        public int banka_id { get; set; }
        public string banka_ad { get; set; }
        public virtual ICollection<Taksitler> Taksitlers { get; set; }
    }
}
