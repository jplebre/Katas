using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.VideoRental.Specflow
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int Age { get; private set; }

        public User(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }
    }
}
