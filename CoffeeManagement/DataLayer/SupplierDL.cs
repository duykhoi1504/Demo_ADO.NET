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
        public List<Supplier> GetSuppliers()
        {
            string sql = "SELECT * FROM Supplier";
            string id, name, address;
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                Connect();
                SqlDataReader reader = MyExcureReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader["name"].ToString();
                    address = reader[2].ToString();
                    Supplier s = new Supplier(id, name, address);
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
                return MyExcuteNonQuery(sql, CommandType.Text);

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
                return MyExcuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
