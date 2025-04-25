using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
//using DataLayer;

namespace DataLayer
{
    public class ItemDL : DataProvider
    {
        public int AddItem(Item item)
        {
            // Câu lệnh SQL để thêm mục
            string sql = @"
                INSERT INTO Item (orderID, productID, quantity, price)
                VALUES (@OrderID, @ProductID, @Quantity, @Price);";

            List<SqlParameter> itemParameters = new List<SqlParameter>
    {
        new SqlParameter("@OrderID", item.orderID),
        new SqlParameter("@ProductID", item.productID),
        new SqlParameter("@Quantity", item.quantity),
        new SqlParameter("@Price", item.price)
    };

            try
            {
                // Thực hiện câu lệnh và lấy ID của mục mới
                return MyExecuteNonQuery(sql, CommandType.Text, itemParameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateItem(Item item)
        {
            // Câu lệnh SQL để cập nhật mục
            string sql = @"
                UPDATE Item
                SET orderID = @OrderID,
                WHERE id = @id;";

            List<SqlParameter> itemParameters = new List<SqlParameter>
    {
        new SqlParameter("@OrderID", item.orderID),
        new SqlParameter("@id", item.id) // ID của mục cần cập nhật
    };

            try
            {
                // Thực hiện câu lệnh update
                return MyExecuteNonQuery(sql, CommandType.Text, itemParameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }

}
