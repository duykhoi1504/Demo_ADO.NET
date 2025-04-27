using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;
namespace BusinessLayer
{
    public class LoginBL
    {
        private LoginDL loginDL;

        public LoginBL()
        {
            loginDL = new LoginDL();
        }

        public bool Login(Account a)
        {
            try
            {
                return loginDL.Login(a);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public Account GetAccount(string username, string password)
        {
            try
            {
                return loginDL.GetAccount(username, password);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //public int GetAccountId(string username)
        //{
        //    try
        //    {
        //        return loginDL.GetAccountId(username);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
