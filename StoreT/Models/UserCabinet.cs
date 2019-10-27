using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class UserCabinet
    {
        public int Id { get; set; }
        public int CabinetId { get; set; }
        public User User { get; set; }
        public string QuantityOrders { get; set; }
    }
}
