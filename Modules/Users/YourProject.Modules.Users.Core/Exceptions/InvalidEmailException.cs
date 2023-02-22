using YourProject.Shared.Exceptions;

namespace YourProject.Modules.Users.Core.Exceptions;

internal sealed class InvalidEmailException : YourProjectException
{
    public string Email { get; }

    public InvalidEmailException(string email) : base($"Email: '{email}' is invalid.")
    {
        Email = email;
    }
}