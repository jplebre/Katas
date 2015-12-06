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
        private List<User> Users;

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
            if (IsUserUnderaged(user))
            {
                return;
            }

            if (NotAllFieldsPresent(user))
            {
                return;
            }

            else
            {
                Users.Add(user);
                _emailServices.SendUserWelcomeEmail(user);
            }
        }

        public List<User> GetListOfUsers()
        {
            return Users;
        } 

        public User GetUserByName()
        {
            return new User();
        }

        public User GetUserByEmail()
        {
            return new User();
        }

        private Boolean IsUserUnderaged(User user)
        {
            return user.Age < 18;
        }

        private Boolean NotAllFieldsPresent(User user)
        {
            return false;
        }
    }
}
