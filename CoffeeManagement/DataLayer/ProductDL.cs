using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Xml.Linq;

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
                    price = float.Parse(reader["price"].ToString());
                    discount = float.Parse(reader["discount"].ToString());
                    categoryID = int.Parse(reader["categoryID"].ToString());

                    byte[] imageData = reader["image"] as byte[];
                    Image image = null;
                    if (imageData != null)
                    {
                        MemoryStream ms = new MemoryStream(imageData);
                        image = Image.FromStream(ms);
                    }

                    Product s = new Product(id, name, price, discount, categoryID, imageData);
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
            //string sql = "INSERT INTO Product (id, name, price, discount, categoryID, image) VALUES ('" + p.id + "','" + p.name + "','" + p.price + "','" + p.discount + "','" + p.image + "')";
            string sql = "uspAddProduct";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", p.id));
            parameters.Add(new SqlParameter("@name", p.name));
            parameters.Add(new SqlParameter("@price", p.price));
            parameters.Add(new SqlParameter("@discount", p.discount));
            parameters.Add(new SqlParameter("@categoryID", p.categoryID));
            //parameters.Add(new SqlParameter("@image", p.image ?? (object)DBNull.Value));

            SqlParameter imgParam = new SqlParameter("@image", SqlDbType.VarBinary);
            if (p.image != null)
                imgParam.Value = p.image;
            else
                imgParam.Value = DBNull.Value;

            parameters.Add(imgParam);

            try
            {
                //return (MyExecuteNonQuery(sql, CommandType.Text));
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public List<Product> GetProductsByCategory(int categoryID)
        {
            string sql = "SELECT * FROM Product WHERE categoryID = @categoryID";

            string id, name;
            float price, discount;
            List<Product> Prods = new List<Product>();

            try
            {
                Connect();

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@categoryID", categoryID));

                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters);
                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader["name"].ToString();
                    price = float.Parse(reader["price"].ToString());
                    discount = float.Parse(reader["discount"].ToString());
                    categoryID = int.Parse(reader["categoryID"].ToString());

                    byte[] imageData = reader["image"] as byte[];
                    Image image = null;
                    if (imageData != null)
                    {
                        MemoryStream ms = new MemoryStream(imageData);
                        image = Image.FromStream(ms);
                    }

                    Product s = new Product(id, name, price, discount, categoryID, imageData);
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

        public int UpdateProduct(Product p)
        {
            string sql = "uspUpdateProduct";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name", p.name));
            parameters.Add(new SqlParameter("@price", p.price));
            parameters.Add(new SqlParameter("@discount", p.discount));
            parameters.Add(new SqlParameter("@categoryID", p.categoryID));

            SqlParameter imgParam = new SqlParameter("@image", SqlDbType.VarBinary);
            if (p.image != null)
                imgParam.Value = p.image;
            else
                imgParam.Value = DBNull.Value;
            parameters.Add(imgParam);

            parameters.Add(new SqlParameter("@id", p.id));

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {             
                throw ex;
            }
        }

        public int DeleteProduct(string id)
        {
            string sql = "DELETE FROM Product WHERE id = '" + id + "'";

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
