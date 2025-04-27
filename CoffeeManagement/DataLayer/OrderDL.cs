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
        public void GetOrder(Order order)
        {
       
            //string sql = "SELECT * FROM Account WHERE username = '" + order.id + "' AND password = '" + a.Password + "'";

            //try
            //{
               
            //    return ((int)(MyExecuteScalar(sql, CommandType.Text))>0);
            //}
            //catch (SqlException ex)
            //{
            //    throw ex;
            //}
          
        
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
                //new SqlParameter("@CouponID", (object)order.CouponID ?? DBNull.Value),
                new SqlParameter("@CouponID", "CP002"),

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
                new SqlParameter("@CouponID", "CP002"), // Sử dụng giá trị null nếu không có coupon
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
