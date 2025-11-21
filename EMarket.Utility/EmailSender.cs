using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BulkyBook.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly string _brevoApiKey;
        private readonly string _senderEmail;
        private readonly string _senderName;
        private readonly HttpClient _httpClient;
        private const string BrevoApiUrl = "https://api.brevo.com/v3/smtp/email";

        public EmailSender(IConfiguration config)
        {
            _brevoApiKey = config.GetValue<string>("Brevo:ApiKey");
            _senderEmail = config.GetValue<string>("Brevo:SenderEmail");
            _senderName = config.GetValue<string>("Brevo:SenderName");

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("api-key", _brevoApiKey);
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailData = new
            {
                sender = new { name = _senderName, email = _senderEmail },
                to = new[] { new { email = email } },
                subject = subject,
                htmlContent = htmlMessage
            };

            var json = JsonSerializer.Serialize(emailData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(BrevoApiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new System.Exception($"Email sending failed: {response.StatusCode}, {error}");
            }
        }
    }
}
