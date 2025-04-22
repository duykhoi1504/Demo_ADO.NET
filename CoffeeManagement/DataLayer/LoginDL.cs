using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
namespace DataLayer
{
    public class LoginDL:DataProvider
    {
        public bool Login(Account a)
        {
            //string sql = "SELECT COUNT(Username) FROM Users WHERE Username = '"+a.Username+"' AND Password = '"+a.Password+"'";
            string sql = "SELECT COUNT(username) FROM Account WHERE username = '" + a.Username + "' AND password = '" + a.Password + "'";

            try
            {
               
                return ((int)(MyExecureScalar(sql, CommandType.Text))>0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
          
        }



    }
}
