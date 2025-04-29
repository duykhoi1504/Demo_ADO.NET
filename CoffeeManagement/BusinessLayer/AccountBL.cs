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
    public class AccountBL
    {
        private AccountDL accountDL;

        public AccountBL()
        {
            accountDL = new AccountDL();
        }

        public List<Account> GetAccounts()
        {
            try
            {
                return accountDL.GetAccounts();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int AddAccount(Account a)
        {
            try
            {
                return accountDL.AddAccount(a);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateAccount(Account a)
        {
            try
            {
                return accountDL.UpdateAccount(a);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteAccount(int id)
        {
            try
            {
                return accountDL.DeleteAccount(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool IsUsernameExists(string username)
        {
            var accs = GetAccounts();
            return accs.Any(c => c.Username == username);
        }
    }
}
