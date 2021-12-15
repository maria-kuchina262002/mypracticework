using mypracticework.Domain;
using System.Collections.Generic;

namespace mypracticework.Repository
{
        public class ReviewStorage
        {
            private Dictionary<int, Review> Reviews { get; } = new();

            public void Create(Review review)
            {
                Reviews.Add(review.ReviewId, review);
            }

            public Review Read(int reviewId)
            {
                return Reviews[reviewId];
            }

            public Review Update(int reviewId, Review newReview)
            {
                Reviews[reviewId] = newReview;
                return Reviews[reviewId];
            }

            public bool Delete(int reviewId)
            {
                return Reviews.Remove(reviewId);
            }

        }
}
