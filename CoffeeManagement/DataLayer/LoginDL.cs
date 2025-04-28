using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Xml.Linq;
namespace DataLayer
{
    public class LoginDL:DataProvider
    {
        public bool Login(Account a)
        {
            string sql = "SELECT COUNT(username) FROM Account WHERE username = '" + a.Username + "' AND password = '" + a.Password + "'";
            try
            {               
                return ((int)(MyExecuteScalar(sql, CommandType.Text))>0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }    
        }
        public Account GetAccount(string username,string password)
        {
            Account acc=new Account();
            string sql = "SELECT * FROM Account WHERE username = '" + username + "' AND password = '" + password + "'";
            try
            {
               
                return ((int)(MyExecuteScalar(sql, CommandType.Text))>0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
