using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;

namespace FatApi.Services.Interfaces
{
    public interface IReviewsServices
    {
        Task<List<ReviewsResponseDto>> GetAllReviewsAsync();
        Task<Reviews> AddReviewAsync(ReviewsRequestDto reviewDto);
        Task<List<ReviewsResponseDto>> DeleteReviewAsync(int reviewId);
    }
}
