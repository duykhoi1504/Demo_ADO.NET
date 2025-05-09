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
        public List<Item> GetItemByOrderID(int id) {
       

            string sql = @"
                SELECT *, p.name AS productName 
                FROM [Item] i 
                JOIN [Product] p ON i.productID = p.id 
                WHERE i.orderID = @orderID";
            List<Item> items = new List<Item>();
            List<SqlParameter> itemParams = new List<SqlParameter>
            {
                new SqlParameter("@orderID", id)
            };
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, itemParams);
                while (reader.Read())
                {
                    Item item = new Item();
                    item.itemID = int.Parse(reader["itemID"].ToString());
                    item.orderID = reader.GetInt32(1);
                    item.productID = reader["productID"].ToString();
                    item.quantity = reader.GetInt32(3);
                    item.price = float.Parse(reader["price"].ToString());
                    item.productName = reader["productName"].ToString();

                    items.Add(item);
                }
                reader.Close();
                return items;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }

        }


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
        new SqlParameter("@id", item.itemID) // ID của mục cần cập nhật
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
