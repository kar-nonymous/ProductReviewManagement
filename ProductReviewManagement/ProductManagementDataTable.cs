using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ProductReviewManagement
{
    class ProductManagementDataTable
    {
        /// <summary>
        /// UC 8: 
        /// Create data table and add data to it
        /// </summary>
        public void CreateDataTable()
        {
            DataTable productsTable = new DataTable();
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
    }
}
