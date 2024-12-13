using FatApi.Dto.ResponseDto;

namespace FatApi.Services.Interfaces
{
    public interface IDifficultiesServices
    {
        Task<DifficultiesResponseDto> GetDifficultyById(int difficultyId);
    }
}
