using System.Threading.Tasks;

namespace Fhazkard_Website.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
