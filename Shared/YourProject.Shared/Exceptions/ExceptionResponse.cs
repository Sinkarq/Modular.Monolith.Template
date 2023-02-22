using System.Net;

namespace YourProject.Shared.Exceptions;

public sealed record ExceptionResponse(object Response, HttpStatusCode StatusCode);