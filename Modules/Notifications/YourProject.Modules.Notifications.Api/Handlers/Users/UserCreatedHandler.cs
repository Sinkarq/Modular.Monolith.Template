using System.Threading;
using System.Threading.Tasks;
using MediatR;
using YourProject.Modules.Notifications.Api.Services;
using YourProject.Modules.Users.Shared.Events;

namespace YourProject.Modules.Notifications.Api.Handlers.Users;

internal sealed class UserCreatedHandler : INotificationHandler<UserCreated>
{
    private readonly IEmailSender _emailSender;

    public UserCreatedHandler(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public Task Handle(UserCreated notification, CancellationToken cancellationToken)
        => _emailSender.SendAsync(notification.Email, "account_created");
}