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
    public class WorkdayDL:DataProvider
    {
        public int AddWorkday(Workday wd)
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

    }
}
