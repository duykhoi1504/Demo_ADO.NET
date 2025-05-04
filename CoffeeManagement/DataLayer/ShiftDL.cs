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
    public class ShiftDL:DataProvider
    {
        public List<Shift> GetShifts()
        {
            string sql = "SELECT * FROM Shift";


            List<Shift> shifts = new List<Shift>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {

                    Shift shift =new Shift();
                    shift.id = int.Parse(reader[0].ToString());
                    shift.name = reader["name"].ToString();
                    shift.time = reader["time"].ToString();
                    shift.wage = reader["wage"].ToString();




                    shifts.Add(shift);
                }
                reader.Close();
                return shifts;
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
    }
}
