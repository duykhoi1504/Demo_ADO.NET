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
        public Account GetAccount(string username, string password)
        {
            Account acc = new Account();
            string sql = "SELECT * FROM Account WHERE username = '" + username + "' AND password = '" + password + "'";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    acc.id = int.Parse(reader[0].ToString());
                    acc.Username = reader["username"].ToString();
                    acc.Password = reader["password"].ToString();

                    acc.role = reader["role"].ToString();
                    //acc.fullName = reader["fullName"].ToString();
                    //acc.sex = reader["sex"].ToString();
                    //acc.dateOfBirth = reader["dateOfBirth"].ToString();
                    //acc.address = reader["address"].ToString();
                    //acc.phoneNumber = reader["phoneNumber"].ToString();
                    //acc.dateOfRegistration = reader["dateOfRegistration"].ToString();
                }
                reader.Close();
                return acc;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
