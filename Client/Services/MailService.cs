namespace Accreditation_Watch.Client.Services;

public class MailService : IMailService
{
    private readonly HttpClient HttpClient;
    public MailService (HttpClient httpClient)
    {
        HttpClient = httpClient;
    }
    public async Task<string> SendEmail(MessageMail mail)
    {
        var request = await HttpClient.PostAsJsonAsync<MessageMail>($"api/mail", mail);
        if (!request.IsSuccessStatusCode) throw new Exception($"Failed to send email: {request.ReasonPhrase}");
    var response = await request.Content.ReadAsStringAsync();   

        return response;
    }
}