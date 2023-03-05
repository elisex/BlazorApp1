using BlazorApp1.Server.Data;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Services.UserFileService
{
    public class UserFileService : IUserFileService
    {
        private readonly DataContext _context;

        public UserFileService(DataContext context)
        {
            _context=context;
        }

        public async Task<List<UserDetails>> GetUserFiles()
        {
            return await _context.UserDetails.ToListAsync();
        }
    }
}
