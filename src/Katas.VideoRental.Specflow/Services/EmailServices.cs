using System;
using System.Net.Mail;
using Katas.VideoRental.Specflow.Models;

namespace Katas.VideoRental.Specflow
{
    public class EmailServices : IEmailServices
    {
        MailMessage MailMessage;
        private CMSEntries _cmsEntries;

        public EmailServices():this(new CMSEntries())
        {
        }

        public EmailServices(CMSEntries cmsEntries)
        {
            _cmsEntries = cmsEntries;
        }

        public void SendUserWelcomeEmail(User user)
        {
            MailMessage = new MailMessage(_cmsEntries.VideoClubEmailAddress,user.Email);
            MailMessage.Subject = _cmsEntries.WelcomeEmailSubject;
            MailMessage.Body = _cmsEntries.WelcomeEmailBody + user.Name;

            Console.WriteLine(MailMessage.ToString());
        }
    }
}