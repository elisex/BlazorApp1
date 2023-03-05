using BlazorApp1.Shared;

namespace BlazorApp1.Server.Services.UserFileService
{
    public interface IUserFileService
    {
        Task<List<UserDetails>> GetUserFiles();
    }
}
