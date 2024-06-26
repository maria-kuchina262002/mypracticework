﻿using Microsoft.AspNetCore.Mvc;
using mypracticework.Domain;
using mypracticework.Repository;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Review")]
    public class ReviewController : ControllerBase
    {
        [HttpPut]
        public Review Create(Review review)
        {
            Storage.ReviewStorage.Create(review);
            return review;
        }

        [HttpGet]
        public Review Read(int reviewId)
        {
            return Storage.ReviewStorage.Read(reviewId);
        }

        [HttpPost]
        public Review Update(int reviewId, Review newReview)
        {
            return Storage.ReviewStorage.Update(reviewId, newReview);
        }

        [HttpDelete]
        public bool Delete(int reviewId)
        {
            return Storage.ReviewStorage.Delete(reviewId);
        }
    }

}
