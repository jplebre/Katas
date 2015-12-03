using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace Katas.VideoRental.Specflow
{
    public interface IEmailServices
    {
        void SendUserWelcomeEmail(User user);
    }
}