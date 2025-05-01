using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class StatsDL:DataProvider
    {
        public StatsDL()
        {
            // Constructor logic here
        }
        public List<Stats> GetStatsByProduct()
        {
            string sql = "GetStatsByProduct";
            List<Stats> stats = new List<Stats>();
            try
            {

                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Stats stat = new Stats();
                    stat.id = reader[0].ToString();
                    stat.name = reader["name"].ToString();
                    stat.value = float.Parse(reader["totalRevenue"].ToString());
                    stats.Add(stat);
                }
                reader.Close();
                return stats;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
