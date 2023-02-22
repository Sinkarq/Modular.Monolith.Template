using System.Threading.Tasks;

namespace YourProject.Modules.Notifications.Api.Services;

internal interface IEmailSender
{
    Task SendAsync(string receiver, string template);
}