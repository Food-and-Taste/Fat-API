using FatApi.DataAccess;
using FatApi.Dto.ResponseDto;
using FatApi.Services.Interfaces;

namespace FatApi.Services
{
    public class DifficultiesServices: IDifficultiesServices
    {
        private readonly FatContext _context;

        public DifficultiesServices(FatContext context)
        {
            _context = context;
        }

        public async Task<DifficultiesResponseDto?> GetDifficultyById(int difficultyId)
        {
            var difficulty = await _context.Difficulties.FindAsync(difficultyId);

            if (difficulty == null)
                return null;

            return new DifficultiesResponseDto
            {
                Id = difficulty.Id,
                Difficulty = difficulty.Difficulty
            };
        }
    }
}
