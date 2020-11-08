using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    class ProductManagement
    {
        /// <summary>
        /// UC 2:
        /// Returns the top three products with maximum rating
        /// </summary>
        /// <param name="productReviewList"></param>
        public void TopThreeRecords(List<ProductReview> productReviewList)
        {
            var recordedData = (from products in productReviewList
                                orderby products.Rating descending
                                select products).Take(3);
            foreach(var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductID + "User ID: " + productReview.UserID + "Rating: " + productReview.Rating + "Review: " + productReview.Review);
            }
        }
        /// <summary>
        /// UC 3:
        /// Returns the products with given condition
        /// </summary>
        /// <param name="list"></param>
        public void RetrieveByCondition(List<ProductReview> list)
        {
            var recordedData = (list.Where(r => r.Rating > 3 && r.ProductID == 1 || r.ProductID == 4 || r.ProductID == 9));
            foreach(var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductID + "User ID: " + productReview.UserID + "Rating: " + productReview.Rating + "Review: " + productReview.Review);
            }
        }
    }
}
