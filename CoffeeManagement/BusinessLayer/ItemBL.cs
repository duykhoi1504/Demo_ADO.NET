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
    public class ItemBL
    {
        private ItemDL itemDL;
        public ItemBL()
        {
            itemDL = new ItemDL();
        }

        public List<Item> GetItemByOrderID(int id)
        {
            try
            {
                return itemDL.GetItemByOrderID(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int AddItem(Item item)
        {
            try
            {
                return itemDL.AddItem(item);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateItem(Item item)
        {
            try
            {
                return itemDL.UpdateItem(item);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
}
    }
}
