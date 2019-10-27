using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class User
    {       
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Type { get; set; }

        public ImageUser ImageUsers { get; set; }
        public UserCabinet UserCabinet { get; set; }
    }
}
