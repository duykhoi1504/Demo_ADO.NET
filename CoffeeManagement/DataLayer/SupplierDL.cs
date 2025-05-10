using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
namespace DataLayer
{
    public class SupplierDL : DataProvider
    {
        public List<Supplier> GetSuppliers( string id=null)
        {
            // Nếu id không được cung cấp, chọn tất cả
            string sql= "";
            if (string.IsNullOrEmpty(id))
            {
                sql = "SELECT * FROM Supplier";
            }
            else
            {
                sql = "SELECT * FROM Supplier WHERE id = '@id'";
            }
            string ids, name, address;
            
            List<Supplier> suppliers = new List<Supplier>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    ids = reader[0].ToString();
                    name = reader["name"].ToString();
                    address = reader[2].ToString();
                    Supplier s = new Supplier(ids, name, address);
                    suppliers.Add(s);
                }
                reader.Close();
                return suppliers;
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
        public int AddSupplier(Supplier s)
        {
            string sql = "insert into Supplier(id,name,address) values('" + s.id + "','" + s.name + "','" + s.address + "')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public int DeleteSupplier(string id)
        {
            string sql = "delete from Supplier where id='" + id + "'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateSupplier(string key, Supplier s)
        {
            string sql = "uspUpdateSupplier";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@key", key));

            parameters.Add(new SqlParameter("@id", s.id));
            parameters.Add(new SqlParameter("@name", s.name));
            parameters.Add(new SqlParameter("@address", s.address));

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
