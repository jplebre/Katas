using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.VideoRental.Specflow
{
    public class Library
    {
        public List<Title> Titles { get; private set; }
        public List<User> Users { get; private set; }  

        public Library()
        {
            Titles = new List<Title>();
            Users = new List<User>();
        }

        public void RegisterUser(string name, string email, int age)
        {
            User user = new User(name, email, age);
            Users.Add(user);
        }
    }
}
