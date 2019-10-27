using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class ImageUser
    {
        public int Id { get; set; }
        public int UserId { get; internal set; }
        public string ImageAddress { get; set; }

        public User Users { get; set; }
    }
}
