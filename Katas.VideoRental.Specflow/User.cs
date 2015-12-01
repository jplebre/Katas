using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.VideoRental.Specflow
{
    public class User
    {
        string Name;
        string Email;
        int Age;

        public User(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }
    }
}
