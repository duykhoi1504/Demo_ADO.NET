using DataLayer;
using System;
using System.Collections.Generic;
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
        public int AddItem(Item item)
        {
            return itemDL.AddItem(item);
        }
        public int UpdateItem(Item item)
        {
            return itemDL.UpdateItem(item);
        }
    }
}
