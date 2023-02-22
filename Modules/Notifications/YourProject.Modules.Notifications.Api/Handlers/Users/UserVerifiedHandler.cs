using MediatR;
using YourProject.Modules.Notifications.Api.Services;
using YourProject.Modules.Users.Shared.Events;

namespace YourProject.Modules.Notifications.Api.Handlers.Users;

internal sealed class UserVerifiedHandler : INotificationHandler<UserVerified>
{
    private readonly IEmailSender _emailSender;

    public UserVerifiedHandler(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public Task Handle(UserVerified notification, CancellationToken cancellationToken)
        => _emailSender.SendAsync(notification.Email, "account_verified");
}