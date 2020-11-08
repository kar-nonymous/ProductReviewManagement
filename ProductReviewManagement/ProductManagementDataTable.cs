using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace ProductReviewManagement
{
    class ProductManagementDataTable
    {
        DataTable productsTable = new DataTable();
        /// <summary>
        /// UC 8: 
        /// Create data table and add data to it
        /// </summary>
        public void CreateDataTable()
        {
            productsTable.Columns.Add("ProductID");
            productsTable.Columns.Add("UserID");
            productsTable.Columns.Add("Rating");
            productsTable.Columns.Add("Review");
            productsTable.Columns.Add("isLike");
            productsTable.Rows.Add("1", "15", "10", "Excellent", "true");
            productsTable.Rows.Add("2", "12", "1", "Poor", "true");
            productsTable.Rows.Add("3", "21", "7", "Average", "false");
            productsTable.Rows.Add("3", "22", "10", "Excellent", "true");
            productsTable.Rows.Add("2", "21", "0", "Poor", "true");
        }
        /// <summary>
        /// UC 9:
        /// Retrieve data from table by isLike condition
        /// </summary>
        public void RetrieveDataWithIsLike()
        {
            var recordedData = from products in productsTable.AsEnumerable()
                               where products.Field<string>("isLike") == "true"
                               select products;
            foreach(var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.Field<string>("ProductID") + " UserID: " + productReview.Field<string>("UserID") + " Rating: " + productReview.Field<string>("Rating") + " Review: " + productReview.Field<string>("Review") + " isLike: " + productReview.Field<string>("isLike"));
            }
        }
        /// <summary>
        /// UC 10: 
        /// Average rating 
        /// </summary>
        public void AverageRatingByProductID()
        {
            var recordedData = productsTable.AsEnumerable().GroupBy(r => r.Field<string>("ProductId")).Select(x => new { ProductId = x.Key, Average = x.Average(r => r.Field<int>("Rating")) });
            foreach(var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductId + " Average: " + productReview.Average);
            }
        }
        /// <summary>
        /// UC 11:
        /// Retrieve data from table by review condition
        /// </summary>
        public void RetrieveDataWithReview()
        {
            var recordedData = from products in productsTable.AsEnumerable()
                               where products.Field<string>("Review") == "nice"
                               select products;
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.Field<string>("ProductID") + " UserID: " + productReview.Field<string>("UserID") + " Rating: " + productReview.Field<string>("Rating") + " Review: " + productReview.Field<string>("Review") + " isLike: " + productReview.Field<string>("isLike"));
            }
        }
    }
}
