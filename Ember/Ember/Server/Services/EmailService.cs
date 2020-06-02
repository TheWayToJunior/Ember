using Ember.Shared;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace Ember.Server.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> logger;
        private readonly IConfiguration configuration;

        public EmailService(ILogger<EmailService> logger, IConfiguration configuration)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task SendMessage(SendMessage message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            try
            {
                var emailMessage = new MimeMessage();

                emailMessage.From.Add(new MailboxAddress(message.UserName, message.Email));
                emailMessage.To.Add(new MailboxAddress(configuration["email:recipient"]));

                emailMessage.Subject = $"Feedback";
                emailMessage.Body = new BodyBuilder()
                {
                    HtmlBody = $"<h4>Contact me by email: {message.Email}</h4>{message.TextBody}"
                }
                .ToMessageBody();

                using (SmtpClient smtpClient = new SmtpClient())
                {
                    await smtpClient.ConnectAsync("smtp.gmail.com", 465, true)
                        .ConfigureAwait(true);

                    await smtpClient.AuthenticateAsync(configuration["email:name"], configuration["email:password"])
                        .ConfigureAwait(true);

                    await smtpClient.SendAsync(emailMessage)
                        .ConfigureAwait(true);

                    await smtpClient.DisconnectAsync(true)
                        .ConfigureAwait(true);
                }

                logger.LogInformation("Сообщение отправлено!");
            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
                throw;
            }
        }
    }
}
