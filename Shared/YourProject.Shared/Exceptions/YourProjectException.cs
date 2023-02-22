using System;

namespace YourProject.Shared.Exceptions;

public abstract class YourProjectException : Exception
{
    protected YourProjectException(string message) : base(message)
    {
    }
}