using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models
{
    public class Account
    {
        public string Email { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public int LoginCounter { get; set; }
        public Types.AccountType Role {get; set;} 
    }
}
