using System.Threading.Tasks;
using YourProject.Modules.Notifications.Shared;

namespace YourProject.Modules.Notifications.Api.Services;

internal sealed class NotificationsModuleApi : INotificationsModuleApi
{
    private readonly IEmailSender _emailSender;

    public NotificationsModuleApi(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public Task SendEmailAsync(string receiver, string template)
        => _emailSender.SendAsync(receiver, template);
}