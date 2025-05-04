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
    public class ShiftBL
    {
        private ShiftDL shiftDL;
        public ShiftBL() {
            shiftDL = new ShiftDL();
        }
        public List<Shift> GetShifts()
        {
            try
            {
                return shiftDL.GetShifts();

            }
            catch ( SqlException ex)
            {
                    throw ex;
            }
        } 
    }
}
