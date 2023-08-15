namespace Accreditation_Watch.Client.Services.Contracts;

public interface IMailService
{
    Task<string> SendEmail(MessageMail mail);
}