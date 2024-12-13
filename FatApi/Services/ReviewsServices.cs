using FatApi.DataAccess;
using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FatApi.Services
{
    public class ReviewsServices: IReviewsServices
    {
        private readonly FatContext _fatContext;

        public ReviewsServices(FatContext fatContext)
        {
            _fatContext = fatContext;
        }

        public async Task<List<ReviewsResponseDto>> GetAllReviewsAsync()
        {
            return await _fatContext.Reviews.Select(review => new ReviewsResponseDto
            {
                Id = review.Id,
                Review = review.Review,
                UserId = review.UserId,
                RecipeId = review.RecipeId
            }).ToListAsync();
        }

        public async Task<Reviews> AddReviewAsync(ReviewsRequestDto reviewDto)
        {
            var review = new Reviews
            {
                Review = reviewDto.Review,
                UserId = reviewDto.UserId,
                RecipeId = reviewDto.RecipeId
            };

            _fatContext.Reviews.Add(review);
            await _fatContext.SaveChangesAsync();

            return review;
        }

        public async Task<List<ReviewsResponseDto>> DeleteReviewAsync(int reviewId)
        {
            var review = await _fatContext.Reviews.FindAsync(reviewId);

            _fatContext.Reviews.Remove(review);
            await _fatContext.SaveChangesAsync();

            return await GetAllReviewsAsync();
        }
    }
}
