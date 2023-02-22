using YourProject.Shared.Exceptions;

namespace YourProject.Modules.Users.Core.Exceptions;

internal sealed class UserAlreadyExistsException : YourProjectException
{
    public string Email { get; }

    public UserAlreadyExistsException(string email) : base($"User with email: '{email}' already exists.")
    {
        Email = email;
    }
}