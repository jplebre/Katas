using System;

namespace Katas.VideoRental.Specflow
{
    public class EmailServices : IEmailServices
    {
        public void SendUserWelcomeEmail(User user)
        {
            Console.WriteLine("Welcome to the videoclub " + user.Name);
        }

    }
}