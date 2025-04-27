using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class CouponDL : DataProvider
    {
        public List<Coupon> GetCoupons()
        {
            string sql = "SELECT * FROM Coupon";

            string id, description;
            float value;

            List<Coupon> coupons = new List<Coupon>();

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

                while (reader.Read())
                {
                    id = reader["id"].ToString();
                    description = reader["description"].ToString();
                    value = float.Parse(reader["value"].ToString());

                    Coupon c = new Coupon(id, description, value);
                    coupons.Add(c);
                }
                reader.Close();
                return coupons;
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

        public int AddCoupon(Coupon c)
        {
            string sql = "INSERT INTO Coupon(id, description, value) VALUES('" + c.id + "', N'" + c.description + "','" + c.value + "')";

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.Text));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateCoupon(Coupon c)
        {
            string sql = "uspUpdateCoupon";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", c.id));
            parameters.Add(new SqlParameter("@description", c.description));
            parameters.Add(new SqlParameter("@value", c.value));

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteCoupon(string id)
        {
            string sql = "DELETE FROM Coupon WHERE id='" + id + "'";

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.Text));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
