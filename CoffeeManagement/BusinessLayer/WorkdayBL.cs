using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class WorkdayBL
    {
        WorkdayDL workdayDL;
        public WorkdayBL()
        {
            workdayDL = new WorkdayDL();
        }
        public int AddWorkday(Workday wd)
        {
            try
            {
                return workdayDL.AddWorkday(wd);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
