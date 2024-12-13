using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FatApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private readonly IUsersServices _usersServices;

        public UsersController(IUsersServices usersServices)
        {
            _usersServices = usersServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsersResponseDto?>>> GetAllUsers()
        {
            var users = await _usersServices.GetAllUsers();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult<Users?>> AddUser(UsersRequestDto userData)
        {
            var user = await _usersServices.AddUser(userData);
            return Ok(user);
        }
    }
}
