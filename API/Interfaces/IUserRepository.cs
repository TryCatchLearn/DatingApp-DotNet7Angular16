using API.Entities;
using API.Helpers;

namespace API.Interfaces;

public interface IUserRepository
{
    // anything that returns a reference type that is not a list make optional
    // and handle this in the controller
    void Update(AppUser user);
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser?> GetUserByIdAsync(int id);
    Task<AppUser?> GetUserByUsernameAsync(string username);
    Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
    Task<MemberDto?> GetMemberAsync(string username);
}

