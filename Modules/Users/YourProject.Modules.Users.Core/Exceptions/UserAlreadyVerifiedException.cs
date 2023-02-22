using System;
using YourProject.Shared.Exceptions;

namespace YourProject.Modules.Users.Core.Exceptions;

internal sealed class UserAlreadyVerifiedException : YourProjectException
{
    public Guid UserId { get; }

    public UserAlreadyVerifiedException(Guid userId) : base($"User with ID: '{userId}' is already verified.")
    {
        UserId = userId;
    }
}