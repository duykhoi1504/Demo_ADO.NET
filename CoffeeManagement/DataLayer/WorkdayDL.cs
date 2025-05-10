using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Net;
using System.Xml.Linq;

namespace DataLayer
{
    public class WorkdayDL : DataProvider
    {

        public List<Workday> GetAllWorkdays(int accountID)
        {
            string sql = "GetWorkDayByAccountID";
            //string sql = "SELECT * FROM Workday";
            List<Workday> workdays = new List<Workday>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@AccountID", accountID));

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.StoredProcedure,parameters);
                while (reader.Read())
                {
                    Workday s = new Workday();
                    s.date = DateTime.Parse(reader["date"].ToString()) ;
                    //s.shiftID = int.Parse(reader["shiftID"].ToString());
                    s.name = reader["name"].ToString();
                    s.time = reader["time"].ToString();

                    s.accountID = int.Parse(reader["accountID"].ToString());
                    s.shiftID = int.Parse(reader["shiftID"].ToString());
                    s.isChecked = reader.GetBoolean(reader.GetOrdinal("isChecked")); // Use GetBoolean for the BIT type
                    workdays.Add(s);
                }
                reader.Close();
                return workdays;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int AddWorkday(Workday wd    )
        {
            string sql = "AddWorkday";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@AccountID", wd.accountID));
            parameters.Add(new SqlParameter("@ShiftID", wd.shiftID));
            parameters.Add(new SqlParameter("@Date", wd.date));
            try
            {
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateWorkday(DateTime date,bool isChecked)
        {
            string sql = "UpdateWorkday";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@date",date));
            parameters.Add(new SqlParameter("@isChecked",isChecked));

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public float CalculateSalary(int accountID, int month,int year)
        {
            string sql = "CalSalaryByAccIDAndDate";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@accountID", accountID));
            parameters.Add(new SqlParameter("@month", month));
            parameters.Add(new SqlParameter("@year", year));

            try
            {
                var result = MyExecuteScalar(sql, CommandType.StoredProcedure, parameters);
                return Convert.ToSingle(result);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
