using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FatApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReviewsController: ControllerBase
    {
        private readonly IReviewsServices _services;

        public ReviewsController(IReviewsServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<ActionResult<List<ReviewsResponseDto>>> GetAllReviewsAsync()
        {
            var reviews = await _services.GetAllReviewsAsync();
            return Ok(reviews);
        }

        [HttpPost]
        public async Task<ActionResult<Reviews>> AddReviewAsync(ReviewsRequestDto reviewDto)
        {
            var review = await _services.AddReviewAsync(reviewDto);
            return Ok(review);
        }

        [HttpDelete("{reviewId}")]
        public async Task<ActionResult<List<ReviewsResponseDto>>> DeleteReviewAsync(int reviewId)
        {
            var review = await _services.DeleteReviewAsync(reviewId);
            return Ok(review);
        }
    }
}
