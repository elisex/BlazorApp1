using BlazorApp1.Shared;
namespace BlazorApp1.Server.Services.UserService
{
    public interface IUserService
    {
        Task<bool> CreateUserAsync(UserDetails user);
    }
}
