using System.Security.Cryptography.X509Certificates;

namespace Katas.VideoRental.Specflow
{
    public interface IEmailServices
    {
        public void SendUserWelcomeEmail(User user);
    }
}