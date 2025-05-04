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
    public class InventoryTransactionDL : DataProvider
    {
        public List<InventoryTransaction> GetTransactions()
        {
			string sql = "SELECT * FROM InventoryTransaction";

			string ingredientID, type, note;
			int id, quantity;
			DateTime date;

			List<InventoryTransaction> t = new List<InventoryTransaction>();

            try
			{
				Connect();
				SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

				while (reader.Read())
				{
					id = int.Parse(reader["id"].ToString());
					ingredientID = reader["ingredientID"].ToString();
                    quantity = int.Parse(reader["quantity"].ToString());
					type = reader["type"].ToString();
					date = DateTime.Parse(reader["date"].ToString());
					note = reader["note"].ToString();

					InventoryTransaction i = new InventoryTransaction(id, ingredientID, quantity, type, date, note);
					t.Add(i);
                }

				reader.Close();
				return t;
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

		public int AddTransaction(InventoryTransaction t)
		{
            string sql = "INSERT INTO InventoryTransaction(ingredientID, quantity, type, date, note) VALUES('" + t.ingredientID + "','" + t.quantity + "','" + t.type + "','" + t.date + "', N'" + t.note + "')";

            try
            {
				return MyExecuteNonQuery(sql, CommandType.Text);
			}
			catch (SqlException ex)
			{
				throw ex;
			}
		}

        public int UpdateTransaction(InventoryTransaction t)
        {
            string sql = "UPDATE InventoryTransaction SET quantity='" + t.quantity + "', type='" + t.type + "', date='" + t.date + "', note='" + t.note + "' WHERE id='" + t.id + "'";

            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteTransaction(int id)
        {
            string sql = "DELETE FROM InventoryTransaction WHERE id = '" + id + "'";

            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<InventoryTransaction> GetTransactionsByIngredient(string ingredientId)
        {
            string sql = "SELECT * FROM InventoryTransaction WHERE IngredientID = '" + ingredientId + "'";

            string ingredientID, type, note;
            int id, quantity;
            DateTime date;

            List<InventoryTransaction> t = new List<InventoryTransaction>();

            try
            {
                Connect();

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@ingredientId", ingredientId));

                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters);

                while (reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                    ingredientID = reader["ingredientID"].ToString();
                    quantity = int.Parse(reader["quantity"].ToString());
                    type = reader["type"].ToString();
                    date = DateTime.Parse(reader["date"].ToString());
                    note = reader["note"].ToString();

                    InventoryTransaction i = new InventoryTransaction(id, ingredientID, quantity, type, date, note);
                    t.Add(i);
                }

                reader.Close();
                return t;
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

        public InventoryTransaction GetTransaction(int id)
        {
            string sql = "SELECT * FROM InventoryTransaction WHERE id = '" + id + "'";

            string ingredientID, type, note;
            int quantity;
            DateTime date;

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

                if (reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                    ingredientID = reader["ingredientID"].ToString();
                    quantity = int.Parse(reader["quantity"].ToString());
                    type = reader["type"].ToString();
                    date = DateTime.Parse(reader["date"].ToString());
                    note = reader["note"].ToString();

                    return new InventoryTransaction(id, ingredientID, quantity, type, date, note);
                }

                reader.Close();
                return null;
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
