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
        public List<Workday> GetAllWorkdays(int accountID)
        {
            try
            {
                return workdayDL.GetAllWorkdays(accountID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
       
        }
        public int AddWorkday(Workday wd)
        {
            if(wd.date <= DateTime.Today || wd.date <= DateTime.Now)
            {
                throw new Exception("Ngày không hợp lệ, không được chọn ngày hôm nay và trước đó!!!!");
            }
            try
            {
                return workdayDL.AddWorkday(wd);
            }
            catch (SqlException ex)
            {
                throw ex;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateWorkday(DateTime date,bool isChecked)
        {
            try
            {
                return workdayDL.UpdateWorkday(date, isChecked);
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
