using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.VideoRental.Specflow
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int LoyaltyPoints { get; set; }
        public UserStatus UserStatus { get; set; }
        public List<string> Wishlist { get; set; } 
    }

    public enum UserStatus{ MEMBER, ADMINISTRATOR }
}
