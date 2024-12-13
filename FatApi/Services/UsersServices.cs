using FatApi.DataAccess;
using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FatApi.Services
{
    public class UsersServices: IUsersServices
    {
        private readonly FatContext _context;

        public UsersServices(FatContext context)
        {
            _context = context;
        }

        public async Task<List<UsersResponseDto>> GetAllUsers()
        {
            return await _context.Users.Select(user => new UsersResponseDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
            }).ToListAsync();
        }

        public async Task<Users?> AddUser(UsersRequestDto userData)
        {
            var user = new Users
            {
                Name = userData.Name,
                Email = userData.Email,
                Password = userData.Password
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
