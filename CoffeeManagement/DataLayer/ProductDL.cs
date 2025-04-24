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

            string id, name, image;
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
                    price = float.Parse(reader["price"].ToString());
                    discount = float.Parse(reader["discount"].ToString());
                    categoryID = int.Parse(reader["categoryID"].ToString());
                    image = reader["image"].ToString();

                    Product s = new Product(id, name, price, discount, categoryID, image);
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

        public int AddProduct(Product p)
        {
            string sql = "INSERT INTO Product (id, name, price, discount, categoryID, image) VALUES ('" + p.id + "','" + p.name + "','" + p.price + "','" + p.discount + "','" + p.image + "')";
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
