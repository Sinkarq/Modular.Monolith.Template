namespace YourProject.Modules.Notifications.Shared;

public interface INotificationsModuleApi
{
    Task SendEmailAsync(string receiver, string template);
}