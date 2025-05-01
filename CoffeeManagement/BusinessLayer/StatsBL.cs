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
        public List<Stats> GetStatsByProduct()
        {
            try
            {
                return statsDL.GetStatsByProduct();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
          
        }
    }
}
