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

        public void UserAddsTitleToWishlist(User user, string titleName)
        {
            WishlistCannotBeNull(user);
            user.Wishlist.Add(titleName.ToLower());
        }

        public bool CheckUserWishlistForTitle(User user, string titleName)
        {
            return user.Wishlist.Contains(titleName.ToLower());
        }

        private void WishlistCannotBeNull(User user)
        {
            if (user.Wishlist == null)
            {
                user.Wishlist = new List<string>();
            }
        }

        private Boolean IsUserUnderaged(User user)
        {
            return user.Age < 18 || user.Age == 0;
        }

        private Boolean NotAllFieldsPresent(User user)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUser(User user)
        {
            return Users.Find(x => x.Equals(user));
        }

        public void AddLoyaltyPointsToUser(User user, int loyaltyPoints)
        {
            user.LoyaltyPoints += loyaltyPoints;
        }
    }
}
