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
    }
}
