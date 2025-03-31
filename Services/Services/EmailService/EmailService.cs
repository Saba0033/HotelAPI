using System.Net.Mail;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using HotelAPI.Domain.Email;
using Humanizer;
using MailKit;



public interface IEmailService
{
    Task SendEmailAsync(string to, string subject, DateTime checkIn, DateTime checkOut, string name, string roomName);
}

public class EmailService : IEmailService
{
    private readonly EmailSettings _emailSettings;

    public EmailService(IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
    }

    public async Task SendEmailAsync(string to, string subject, DateTime checkIn, DateTime checkOut, string name, string roomName)
    {
        var htmlTemplate = File.ReadAllText("C:\\Users\\Saba\\Desktop\\HotelAPI\\Services\\Services\\EmailService\\template.html"); 

      
        htmlTemplate = htmlTemplate.Replace("{{CustomerName}}", name);
        htmlTemplate = htmlTemplate.Replace("{{CheckInDate}}", checkIn.Date + " (" + checkIn.Humanize() + ")");
        htmlTemplate = htmlTemplate.Replace("{{CheckOutDate}}", checkOut.Date + " (" + checkOut.Humanize() + ")");
        htmlTemplate = htmlTemplate.Replace("{{RoomName}}", roomName);
        var emailMessage = new MimeMessage();
        emailMessage.From.Add(new MailboxAddress("HotelAPI", _emailSettings.FromAddress));
        emailMessage.To.Add(new MailboxAddress("", to));
        emailMessage.Subject = subject;
        emailMessage.MessageId = Guid.NewGuid().ToString();

        var bodyBuilder = new BodyBuilder { HtmlBody = htmlTemplate };
        emailMessage.Body = bodyBuilder.ToMessageBody();

        using (var client = new MailKit.Net.Smtp.SmtpClient())
        {
            await client.ConnectAsync(_emailSettings.Host, _emailSettings.Port, false);
            await client.AuthenticateAsync(_emailSettings.Username, "misq httk gtnt daap");
            await client.SendAsync(emailMessage);
            await client.DisconnectAsync(true);
        }
    }
}