using BlazorApp1.Server.Services.UserFileService;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFileController : ControllerBase
    {
        private readonly IUserFileService _userFileService;

        public UserFileController(IUserFileService userFileService) 
        { 
            _userFileService= userFileService;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserDetails>>> GetUserFiles()
        {
            return Ok(await _userFileService.GetUserFiles());
        }
    }
}
