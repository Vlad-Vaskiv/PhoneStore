using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class Charachteristic
    {
        public int Id { get; set; }
        public int ModelId { get; set; }

        public string display { get; set; }
        public string camera { get; set; }
        public string processor { get; set; }
        public string storage { get; set; }
        public string battery { get; set; }
        public string others { get; set; }
        public string price { get; set; }
        public ModelPhone ModelPhone { get; set; }
    }
}
