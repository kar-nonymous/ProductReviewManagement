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
        /// <summary>
        /// UC 4:
        /// Returns the count by product id.
        /// </summary>
        /// <param name="list"></param>
        public void CountByProductID(List<ProductReview> list)
        {
            var recordedData = list.GroupBy(p => p.ProductID).Select(x => new { productID = x.Key, count = x.Count() });
            foreach(var productReview in recordedData)
            {
                Console.WriteLine("ProductID: " + productReview.productID + "\tCount: " + productReview.count);
            }
        }
        /// <summary>
        /// UC 5:
        /// Returns the product id and review of all the products
        /// </summary>
        /// <param name="list"></param>
        public void RetrieveProductIDAndReview(List<ProductReview> list)
        {
            var recordedData = (from products in list
                                select new { products.ProductID, products.Review });
            foreach(var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductID + "\tReviews: " + productReview.Review);
            }
        }
        /// <summary>
        /// UC 6:
        /// Skips the top 5 entries from the list
        /// </summary>
        /// <param name="list"></param>
        public void SkipTopFive(List<ProductReview> list)
        {
            var recordedData = (from products in list
                                select products).Skip(5);
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductID + "User ID: " + productReview.UserID + "Rating: " + productReview.Rating + "Review: " + productReview.Review);
            }
        }
        /// <summary>
        /// UC 7:
        /// Retrieves product id and reviews of all the products
        /// </summary>
        /// <param name="list"></param>
        public void RetrieveProductIDAndReviewWithSelect(List<ProductReview> list)
        {
            var recordedData = list.Select(x => new { ProductID = x.ProductID, Review = x.Review });
            foreach(var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductID + " Review: " + productReview.Review);
            }
        }
    }
}
