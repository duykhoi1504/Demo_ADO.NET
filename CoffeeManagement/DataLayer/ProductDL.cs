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
    public class ProductDL : DataProvider
    {
        public List<Product> GetProducts()
        {
            string sql = "SELECT * FROM Product";
            string id, name;
            float price, discount;
            int categoryID;
            List<Product> Prods = new List<Product>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader["name"].ToString();
                    price = reader.GetInt32("price");
                    discount = reader.GetInt32("discount");
                    categoryID = reader.GetInt32("categoryID");
                    Product s = new Product(id, name, price, discount, categoryID);
                    Prods.Add(s);
                }
                reader.Close();
                return Prods;
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
    }
}
