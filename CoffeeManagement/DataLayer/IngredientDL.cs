using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class IngredientDL : DataProvider
    {
        public List<Ingredient> GetIngredients()
        {
			string sql = "SELECT * FROM Ingredient";

			string id, name, unit, status, supplierID;
			int quantity;
			DateTime expirationDate;

			List<Ingredient> ingredients = new List<Ingredient>();

            try
			{
				Connect();
				SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

				while (reader.Read())
				{
					id = reader["id"].ToString();
					name = reader["name"].ToString();
					unit = reader["unit"].ToString();
					quantity = int.Parse(reader["quantity"].ToString());
                    expirationDate = (DateTime)reader["expirationDate"];
                    status = reader["status"].ToString();
					supplierID = reader["supplierID"].ToString();

					Ingredient i = new Ingredient(id, name, unit, quantity, expirationDate, status, supplierID);
					ingredients.Add(i);
				}
				reader.Close();
				return ingredients;
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

        public int AddIngredient(Ingredient i)
        {
            string sql = "INSERT INTO Ingredient(id, name, unit, quantity, expirationDate, status, supplierID) VALUES('" + i.id + "', N'" + i.name + "', N'" + i.unit + "','" + i.quantity + "','" + i.expirationDate + "', N'" + i.status + "','" + i.supplierID + "')";

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.Text));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateIngredient(Ingredient i)
        {
            string sql = "GetStatsByProduct";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", i.id));
            parameters.Add(new SqlParameter("@name", i.name));
            parameters.Add(new SqlParameter("@unit", i.unit));
            parameters.Add(new SqlParameter("@quantity", i.quantity));
            parameters.Add(new SqlParameter("@expirationDate", i.expirationDate));
            parameters.Add(new SqlParameter("@status", i.status));
            parameters.Add(new SqlParameter("@supplierID", i.supplierID));

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteIngredient(string id)
        {
            string sql = "DELETE FROM Ingredient WHERE id = '" + id + "'";

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.Text));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Ingredient> GetIngredientsBySupplier(string supplierID)
        {
            string sql = "SELECT * FROM Ingredient WHERE supplierID = '" + supplierID + "'";

            string id, name, unit, status;
            int quantity;
            DateTime expirationDate;

            List<Ingredient> ingredients = new List<Ingredient>();

            try
            {
                Connect();

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@supplierID", supplierID));

                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters);

                while (reader.Read())
                {
                    id = reader["id"].ToString();
					name = reader["name"].ToString();
					unit = reader["unit"].ToString();
					quantity = int.Parse(reader["quantity"].ToString());
                    expirationDate = (DateTime)reader["expirationDate"];
                    status = reader["status"].ToString();
					supplierID = reader["supplierID"].ToString();

                    Ingredient i = new Ingredient(id, name, unit, quantity, expirationDate, status, supplierID);
                    ingredients.Add(i);
                }
                reader.Close();
                return ingredients;
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

        public List<Ingredient> GetIngredientsByStatus(string status)
        {
            string sql = "SELECT * FROM Ingredient WHERE status = '" + status + "'";

            string id, name, unit, supplierID;
            int quantity;
            DateTime expirationDate;

            List<Ingredient> ingredients = new List<Ingredient>();

            try
            {
                Connect();

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@status", status));

                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters);

                while (reader.Read())
                {
                    id = reader["id"].ToString();
                    name = reader["name"].ToString();
                    unit = reader["unit"].ToString();
                    quantity = int.Parse(reader["quantity"].ToString());
                    expirationDate = (DateTime)reader["expirationDate"];
                    status = reader["status"].ToString();
                    supplierID = reader["supplierID"].ToString();

                    Ingredient i = new Ingredient(id, name, unit, quantity, expirationDate, status, supplierID);
                    ingredients.Add(i);
                }
                reader.Close();
                return ingredients;
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
