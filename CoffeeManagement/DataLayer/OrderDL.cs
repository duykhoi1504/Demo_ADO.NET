using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class OrderDL : DataProvider
    {
        public Order GetOrderByID(int id)
        {
                string sql = "SELECT * FROM [Order] where id='"+id+"'";
               Order order = new Order();
        

       
                try
                {
                    Connect();
                    SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                    while (reader.Read())
                    {
                     
                        order.id = int.Parse(reader[0].ToString());
                        order.createdDate = reader["createdDate"].ToString();
                        order.totalPrice = float.Parse(reader["totalPrice"].ToString());
                        order.counterfeit = float.Parse(reader["counterfeit"].ToString());
                        order.change = float.Parse(reader["change"].ToString());
                        order.paymentMethod = reader["paymentMethod"].ToString();
                        order.couponID = reader["couponID"].ToString();
                        order.accountID = int.Parse(reader["accountID"].ToString());

                
                    }
                    reader.Close();
                    return order;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
        }
        public List<Order> GetOrders()
        {

            string sql = "SELECT * FROM [Order]";
            List<Order> orders = new List<Order>();

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Order order = new Order();
                    order.id = int.Parse(reader[0].ToString());
                    order.createdDate = reader["createdDate"].ToString();
                    order.totalPrice = float.Parse(reader["totalPrice"].ToString());
                    order.counterfeit = float.Parse(reader["counterfeit"].ToString());

                    order.change = float.Parse(reader["change"].ToString());
                    order.paymentMethod =reader["paymentMethod"].ToString();
                    order.couponID = reader["couponID"].ToString();
                    order.accountID = int.Parse(reader["accountID"].ToString());
                    
                    orders.Add(order);
                }
                reader.Close();
                return orders;
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
        public int AddOrder(Order order)
        {

            //insert order
            string sql = @"
                        INSERT INTO [Order] (totalPrice, counterfeit, [change], paymentMethod, couponID, accountID)
                       OUTPUT INSERTED.id
                        VALUES (@TotalPrice, @Counterfeit, @Change, @PaymentMethod, @CouponID, @AccountID);";

            List<SqlParameter> orderParameters = new List<SqlParameter>
            {
                new SqlParameter("@TotalPrice", order.totalPrice),
                new SqlParameter("@Counterfeit", order.counterfeit),
                new SqlParameter("@Change", order.change),
                new SqlParameter("@PaymentMethod", order.paymentMethod),
                new SqlParameter("@CouponID", order.couponID ?? (object)DBNull.Value),

                new SqlParameter("@AccountID", order.accountID) 
            };
            try
            {

                //return MyExecuteNonQuery(sql, CommandType.Text, orderParameters);

                // Thực hiện câu lệnh và lấy ID của đơn hàng mới
                int newOrderId = (int)MyExecuteScalar(sql, CommandType.Text, orderParameters);

                // Cập nhật ID cho đối tượng Order
                order.id = newOrderId;

                return newOrderId; // Trả về ID của đơn hàng mới


            }
            catch (SqlException ex)
            {
                throw ex;

            }


            //// Insert Items

            //string insertItemQuery = @"
            //INSERT INTO Item (orderID, productID, quantity, price)
            //VALUES (@OrderID, @ProductID, @Quantity, @Price);";

            //foreach (var item in order.Items)
            //{
            //    List<SqlParameter> itemParameters = new List<SqlParameter>
            //    {
            //        new SqlParameter("@OrderID", item.orderID),
            //        new SqlParameter("@ProductID", item.productID),
            //        new SqlParameter("@Quantity", item.quantity),
            //        new SqlParameter("@Price", item.price)
            //    };

            //    try
            //    {
            //       MyExecuteNonQuery(insertItemQuery, CommandType.Text, itemParameters);
            //    }
            //    catch (SqlException ex)
            //    {
            //        throw ex;

            //    }
            //}
        }
        public int UpdateOrder(Order order)
        {
            // Câu lệnh SQL để cập nhật đơn hàng
            string sql = @"
                UPDATE [Order]
                SET totalPrice = @TotalPrice,
                    counterfeit = @Counterfeit,
                    [change] = @Change,
                    paymentMethod = @PaymentMethod,
                    couponID = @CouponID,
                    accountID = @AccountID
                WHERE id = @OrderID;";

            List<SqlParameter> orderParameters = new List<SqlParameter>
            {
                new SqlParameter("@TotalPrice", order.totalPrice),
                new SqlParameter("@Counterfeit", order.counterfeit),
                new SqlParameter("@Change", order.change),
                new SqlParameter("@PaymentMethod", order.paymentMethod),
                new SqlParameter("@CouponID", order.couponID ?? (object)DBNull.Value), // Sử dụng giá trị null nếu không có coupon
                new SqlParameter("@AccountID", order.accountID),
                new SqlParameter("@OrderID", order.id) // ID của đơn hàng cần cập nhật
            };

            try
            {
                // Thực hiện câu lệnh update
                return MyExecuteNonQuery(sql, CommandType.Text, orderParameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
    }
}
