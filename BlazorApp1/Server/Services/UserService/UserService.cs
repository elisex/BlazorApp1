using BlazorApp1.Server.Data;
using BlazorApp1.Shared;

namespace BlazorApp1.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _dbContext;

        public UserService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateUserAsync(UserDetails user)
        {
            try
            {
                _dbContext.UserDetails.Add(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
