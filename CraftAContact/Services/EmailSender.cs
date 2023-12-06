//EmailSender class to implement the IEmailSender interface

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace CraftAContact.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly string _sendGridApiKey;
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(string sendGridApiKey, ILogger<EmailSender> logger)
        {
            _sendGridApiKey = sendGridApiKey;
            _logger = logger;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {
                var client = new SendGridClient(_sendGridApiKey);
                var from = new EmailAddress("esk4808@umoncton.ca", "Craft-A-Contact");
                var to = new EmailAddress(email);
                var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
                var response = await client.SendEmailAsync(msg);

                // Log the response to check if there are issues
                _logger.LogInformation(response.StatusCode.ToString());
                _logger.LogInformation(await response.Body.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Email sending failed");
            }
            
        }

    }
}
