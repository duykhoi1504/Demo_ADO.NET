using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class InventoryTransactionBL
    {
        private InventoryTransactionDL inventoryTransactionDL;

        public InventoryTransactionBL()
        {
            inventoryTransactionDL = new InventoryTransactionDL();
        }

        public List<InventoryTransaction> GetTransactions()
        {
            try
            {
                return inventoryTransactionDL.GetTransactions();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int AddTransaction(InventoryTransaction t)
        {
            try
            {
                return inventoryTransactionDL.AddTransaction(t);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateTransaction(InventoryTransaction t)
        {
            try
            {
                return inventoryTransactionDL.UpdateTransaction(t);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteTransaction(int id)
        {
            try
            {
                return inventoryTransactionDL.DeleteTransaction(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
