//IEmailSender interface to take care of sending emails

using System.Threading.Tasks;

namespace CraftAContact.Services
{
    public interface IEmailSender
    {
        public interface IEmailSender
        {
            Task SendEmailAsync(string email, string subject, string htmlMessage);
        }
    }
}
