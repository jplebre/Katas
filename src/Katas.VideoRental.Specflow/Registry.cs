using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.VideoRental.Specflow
{
    public class Registry
    {
        private IEmailServices _emailServices;
        public List<User> Users { get; private set; }

        public Registry() : this(new EmailServices())
        {
        }

        public Registry(IEmailServices emailServices)
        {
            _emailServices = emailServices;
            Users = new List<User>();
        }

        public void RegisterUser(User user)
        {
            Users.Add(user);
            _emailServices.SendUserWelcomeEmail(user);
        }
    }
}
