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
    public class AccountDL : DataProvider
    {
        public List<Account> GetAccounts()
        {
            string sql = "SELECT * FROM Account";

            int id;
            string username, password, role, fullName, sex, address, phoneNumber;
            DateTime dateOfBirth, dateOfRegistration;

            List<Account> Accs = new List<Account>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                    role = reader["role"].ToString();
                    fullName = reader["fullname"].ToString();
                    sex = reader["sex"].ToString();
                    dateOfBirth = (DateTime)reader["dateOfBirth"];
                    address = reader["address"].ToString();
                    phoneNumber = reader["phoneNumber"].ToString();
                    dateOfRegistration = (DateTime)reader["dateOfRegistration"];

                    Account acc = new Account(id, username, password, role, fullName, sex, dateOfBirth, address, phoneNumber, dateOfRegistration);
                    Accs.Add(acc);
                }
                reader.Close();
                return Accs;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }

        public int AddAccount(Account a)
        {
            string sql = "uspAddAccount";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@username", a.Username));
            parameters.Add(new SqlParameter("@password", a.Password));
            parameters.Add(new SqlParameter("@role", a.role));
            parameters.Add(new SqlParameter("@fullName", a.fullName));
            parameters.Add(new SqlParameter("@sex", a.sex));
            parameters.Add(new SqlParameter("@dateOfBirth", a.dateOfBirth));
            parameters.Add(new SqlParameter("@address", a.address));
            parameters.Add(new SqlParameter("@phoneNumber", a.phoneNumber));

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateAccount(Account a)
        {
            string sql = "uspUpdateAccount";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@username", a.Username));
            parameters.Add(new SqlParameter("@password", a.Password));
            parameters.Add(new SqlParameter("@role", a.role));
            parameters.Add(new SqlParameter("@fullName", a.fullName));
            parameters.Add(new SqlParameter("@sex", a.sex));
            parameters.Add(new SqlParameter("@dateOfBirth", a.dateOfBirth));
            parameters.Add(new SqlParameter("@address", a.address));
            parameters.Add(new SqlParameter("@phoneNumber", a.phoneNumber));

            parameters.Add(new SqlParameter("@id", a.id));

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteAccount(int id)
        {
            string sql = "DELETE FROM Account WHERE id = '" + id + "'";

            try
            {
                return (MyExecuteNonQuery(sql, CommandType.Text));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
