using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTPlay2.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int BookId { get; set; }
    }

    public class ReviewViewModel {

        public int BookId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public ReviewViewModel()
        {

        }

        public ReviewViewModel(Review review)
        {
            if (review == null)
                return;

            BookId = review.BookId;
            Rating = review.Rating;
            Description = review.Description;
        }

        public Review ToReview()
        {
            return new Review {
                BookId = BookId,
                Description = Description,
                Rating = Rating
            };
        }



    }
}