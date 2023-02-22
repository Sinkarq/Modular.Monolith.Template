﻿using System;
using MediatR;

namespace YourProject.Modules.Users.Shared.Events;

public record UserCreated(Guid UserId, string Email, string FullName, string Nationality) : INotification;