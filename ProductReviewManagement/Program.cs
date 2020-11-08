using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management Program");
            /// UC 1
            /// Creating list and adding data to it
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=2,Rating=6,Review="Average",isLike=true},
                new ProductReview(){ProductID=2,UserID=5,Rating=7,Review="Good",isLike=false},
                new ProductReview(){ProductID=3,UserID=10,Rating=2,Review="Bad",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=10,Review="Average",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Average",isLike=false},
                new ProductReview(){ProductID=3,UserID=2,Rating=0,Review="Good",isLike=true},
                new ProductReview(){ProductID=1,UserID=2,Rating=0,Review="Bad",isLike=false},
                new ProductReview(){ProductID=1,UserID=2,Rating=8,Review="Bad",isLike=true},
                new ProductReview(){ProductID=1,UserID=2,Rating=10,Review="Excellent",isLike=true},
                new ProductReview(){ProductID=10,UserID=2,Rating=10,Review="Average",isLike=true},
                new ProductReview(){ProductID=10,UserID=2,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=22,UserID=2,Rating=1,Review="Bad",isLike=true},
                new ProductReview(){ProductID=1,UserID=2,Rating=1,Review="Average",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=8,Review="Average",isLike=false},
                new ProductReview(){ProductID=22,UserID=2,Rating=9,Review="Good",isLike=false},
                new ProductReview(){ProductID=16,UserID=2,Rating=10,Review="Good",isLike=false},
                new ProductReview(){ProductID=18,UserID=2,Rating=0,Review="Average",isLike=true},
                new ProductReview(){ProductID=18,UserID=2,Rating=10,Review="Average",isLike=true},
                new ProductReview(){ProductID=18,UserID=2,Rating=6,Review="Bad",isLike=false},
                new ProductReview(){ProductID=20,UserID=2,Rating=6,Review="Good",isLike=true},
                new ProductReview(){ProductID=21,UserID=2,Rating=8,Review="Good",isLike=false},
                new ProductReview(){ProductID=22,UserID=2,Rating=8,Review="Bad",isLike=true},
                new ProductReview(){ProductID=23,UserID=2,Rating=3,Review="Average",isLike=true},
                new ProductReview(){ProductID=24,UserID=2,Rating=2,Review="Average",isLike=false},
                new ProductReview(){ProductID=25,UserID=2,Rating=1,Review="Average",isLike=true}
            };
            ProductManagement productManagement = new ProductManagement();
            ///Calling the TopThreeRecords method from ProductManagement class
            Console.WriteLine("\nTop three records with highest rating");
            productManagement.TopThreeRecords(productReviewList);
            /// Calling the RetrieveByCondition method from ProductManagement class
            Console.WriteLine("\nRecords with the provided conditions");
            productManagement.RetrieveByCondition(productReviewList);
            /// Calling the CountByProductID method from ProductManagement class
            Console.WriteLine("\nCount of product id--");
            productManagement.CountByProductID(productReviewList);
            /// Calling the RetrieveProductIDAndReview method from ProductManagement class
            Console.WriteLine("\nProduct ID and Review of every product");
            productManagement.RetrieveProductIDAndReview(productReviewList);
            /// Calling the SkipTopFive method from ProductManagement class
            Console.WriteLine("\nSkipped the top 5 entries from the list");
            productManagement.SkipTopFive(productReviewList);
        }
    }
}
