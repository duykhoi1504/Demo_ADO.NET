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
    public class StatsBL
    {
        StatsDL statsDL ;
        public StatsBL()
        {
            statsDL = new StatsDL();
        }
        public List<Stats> GetStatsByProduct(string year)
        {
            try
            {
                return statsDL.GetStatsByProduct(year);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
          
        }
        public List<Stats> GetStatsByMonth(string year)
        {
            try
            {
                return statsDL.GetStatsByMonth(year);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
    }
}
