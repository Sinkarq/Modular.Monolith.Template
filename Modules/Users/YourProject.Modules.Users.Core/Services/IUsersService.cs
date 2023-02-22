using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YourProject.Modules.Users.Shared.DTO;

namespace YourProject.Modules.Users.Core.Services;

public interface IUsersService
{
    Task<UserDetailsDto> GetAsync(Guid userId);
    Task<UserDetailsDto> GetAsync(string email);
    Task<IReadOnlyList<UserDto>> BrowseAsync();
    Task AddAsync(UserDetailsDto dto);
    Task VerifyAsync(Guid userId);
    
    string GenerateJwtToken(string userId,string username, string secret, IList<string> roles);
}