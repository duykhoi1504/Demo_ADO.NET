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
    public class CategoryDL:DataProvider
    {
        public List<Category> GetCategories()
        {
            string sql = "SELECT * FROM Category";
            string id, name;
            List<Category> cats = new List<Category>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = reader[0].ToString();
                    name = reader["name"].ToString();

                    Category s = new Category(id, name);
                    cats.Add(s);
                }
                reader.Close();
                return cats;
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
