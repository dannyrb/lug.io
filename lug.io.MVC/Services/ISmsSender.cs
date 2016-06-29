using System.Threading.Tasks;

namespace lug.io.MVC.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
