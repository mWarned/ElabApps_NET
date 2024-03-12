using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiulIndividual3
{
    internal class Review
    {
        private String review;
        private int rating;

        public Review(string review, int rating) { 
            this.review = review;
            this.rating = rating;
        }

        public String getReview()
        {
            return review;
        }

        public void setReview(String review)
        {
            this.review = review;
        }

        public int getRating() {
            return rating;
        }

        public void setRating(int rating)
        {
            this.rating = rating;
        }
    }
}
