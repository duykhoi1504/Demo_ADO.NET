using DataLayer;
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
    public class StatsDL:DataProvider
    {

        public List<Stats> GetStatsByProduct(string year)
        {
            string sql = "GetStatsByProduct";
            List<Stats> stats = new List<Stats>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Year", year));

            try
            {

                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.StoredProcedure,parameters);
                while (reader.Read())
                {
                    Stats stat = new Stats();
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
        public List<Stats> GetStatsByMonth(string year)
        {
            string sql = "GetMonthlyRevenue";
            List<Stats> stats = new List<Stats>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Year", year));

            try
            {

                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.StoredProcedure, parameters);
                while (reader.Read())
                {
                    Stats stat = new Stats();

                    stat.name = reader["Month"].ToString();
                    stat.value = float.Parse(reader["TotalRevenue"].ToString());
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
