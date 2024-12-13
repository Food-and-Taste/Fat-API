using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;

namespace FatApi.Services.Interfaces
{
    public interface IUsersServices
    {
        Task<List<UsersResponseDto?>> GetAllUsers();
        Task<Users?> AddUser(UsersRequestDto userData);
    }
}
