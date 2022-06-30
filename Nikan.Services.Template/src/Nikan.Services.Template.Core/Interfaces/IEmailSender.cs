using System.Threading.Tasks;

namespace Nikan.Services.Template.Core.Interfaces
{
  public interface IEmailSender
  {
    Task SendEmailAsync(string to, string from, string subject, string body);
  }
}