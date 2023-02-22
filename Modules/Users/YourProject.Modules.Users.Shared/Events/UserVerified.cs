using System;
using MediatR;

namespace YourProject.Modules.Users.Shared.Events;

public record UserVerified(Guid UserId, string Email, string Nationality) : INotification;