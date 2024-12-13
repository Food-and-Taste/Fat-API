using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;

namespace FatApi.Services.Interfaces
{
    public interface IListsServices
    {
        Task<List<ListsResponseDto>> GetAllLists(); 
        Task<Lists> AddList(ListsRequestDto listDto);
    }
}