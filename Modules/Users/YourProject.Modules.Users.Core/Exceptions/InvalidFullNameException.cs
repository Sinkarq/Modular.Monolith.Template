using YourProject.Shared.Exceptions;

namespace YourProject.Modules.Users.Core.Exceptions;

internal sealed class InvalidFullNameException : YourProjectException
{
    public string FullName { get; }

    public InvalidFullNameException(string fullName) : base($"Full name: '{fullName}' is invalid.")
    {
        FullName = fullName;
    }
}