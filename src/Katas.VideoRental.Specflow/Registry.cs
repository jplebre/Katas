using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.VideoRental.Specflow
{
    public class Registry
    {
        public List<User> Users { get; private set; }

        public Registry()
        {
            Users = new List<User>();
        } 

        public void RegisterUser(User user)
        {
            Users.Add(user);
        }
    }


}
