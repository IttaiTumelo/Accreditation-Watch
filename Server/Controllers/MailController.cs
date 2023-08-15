global using MimeKit;
global using MailKit.Net.Smtp;
global using MimeKit.Text;

namespace Accreditation_Watch.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MailController : ControllerBase
    {
        public MailController()
        {
        }
        
        [HttpPost]
        public async Task<ActionResult> SendMail(MessageMail mail)
        {
            string failed = null;
            var mailMessage = new MimeMessage();
            foreach (var item in mail.Email)
            {
                mailMessage.To.Add(MailboxAddress.Parse(item));
            }
            //mailMessage.To.Add(MailboxAddress.Parse(mail.Email));
            mailMessage.From.Add(MailboxAddress.Parse("ittai1tumelo@gmail.com"));
            mailMessage.Subject = mail.Subject;
            mailMessage.Body = new TextPart(TextFormat.Html)
            {
                Text = mail.Message
            };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("ittai1tumelo@gmail.com", "afafkaiircnnyzhq");
            try
            {
                var response = await smtp.SendAsync(mailMessage);
                //if(response is not null)
                //if (!response) throw new Exception("Wow");
            }
            catch (Exception ex)
            {
                failed = ex.Message;

            }
            finally
            {
                smtp.Disconnect(true);
            }
            if (failed is null)
                return Ok(value: "Sent");
            else return BadRequest(failed);

        }
    }
}
