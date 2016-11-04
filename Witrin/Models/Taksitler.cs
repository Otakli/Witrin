using System;
using System.Collections.Generic;

namespace Witrin.Models
{
    public partial class Taksitler
    {
        public int id { get; set; }
        public int banka_id { get; set; }
        public int taksit { get; set; }
        public string oran { get; set; }
        public virtual Bankalar Bankalar { get; set; }
    }
}
