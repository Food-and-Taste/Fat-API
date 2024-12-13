using FatApi.Dto.ResponseDto;
using FatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FatApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class DifficultiesController: ControllerBase
    {
        private readonly IDifficultiesServices _difficultiesServices;

        public DifficultiesController(IDifficultiesServices difficultiesServices)
        {
            _difficultiesServices = difficultiesServices;
        }

        [HttpGet("{difficultyId}")]
        public async Task<ActionResult<DifficultiesResponseDto>> GetDifficultyById(int difficultyId)
        {
            var difficulty = await _difficultiesServices.GetDifficultyById(difficultyId);
            return Ok(difficulty);
        }
    }
}
