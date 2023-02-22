using YourProject.Modules.Users.Shared.DTO;

namespace YourProject.Modules.Users.Shared;

public interface IUsersModuleApi
{
    Task<UserDetailsDto> GetUserAsync(Guid userId);
    Task<UserDetailsDto> GetUserAsync(string email);
}