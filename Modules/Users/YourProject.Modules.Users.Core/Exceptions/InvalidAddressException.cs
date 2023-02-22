using YourProject.Shared.Exceptions;

namespace YourProject.Modules.Users.Core.Exceptions;

internal sealed class InvalidAddressException : YourProjectException
{
    public string Address { get; }

    public InvalidAddressException(string address) : base($"Address: '{address}' is invalid.")
    {
        Address = address;
    }
}