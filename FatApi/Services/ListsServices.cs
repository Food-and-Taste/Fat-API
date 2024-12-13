using FatApi.DataAccess;
using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FatApi.Services
{
    public class ListsServices: IListsServices
    {
        private readonly FatContext _fatContext;

        public ListsServices(FatContext fatContext)
        {
            _fatContext = fatContext;
        }

        public async Task<List<ListsResponseDto>> GetAllLists()
        {
            return await _fatContext.List.Select(list => new ListsResponseDto
            {
                Id = list.Id,
                UserId = list.UserId
            }).ToListAsync();
        }

        public async Task<Lists> AddList(ListsRequestDto listDto)
        {
            var list = new Lists
            {
                UserId = listDto.UserId
            };

            _fatContext.List.Add(list);
            await _fatContext.SaveChangesAsync();

            return list;
        }
    }
}