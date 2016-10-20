using System.Threading.Tasks;

namespace Fhazkard_Website.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
