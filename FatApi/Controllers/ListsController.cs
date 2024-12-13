using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FatApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ListsController: ControllerBase
    {
        private readonly IListsServices _listsServices;

        public ListsController(IListsServices listsServices)
        {
            _listsServices = listsServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<ListsResponseDto>>> GetAllLists()
        {
            var lists = await _listsServices.GetAllLists();
            return Ok(lists);
        }

        [HttpPost]
        public async Task<ActionResult<Lists>> AddList(ListsRequestDto listDto)
        {
            var list = await _listsServices.AddList(listDto);
            return Ok(list);
        }
    }
}
