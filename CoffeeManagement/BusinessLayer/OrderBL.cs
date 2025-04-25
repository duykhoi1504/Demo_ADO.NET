using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
namespace BusinessLayer
{
    public  class OrderBL
    {
        private OrderDL orderDL;
        public OrderBL()
        {
            orderDL = new OrderDL();
        }
        public int AddOrder(Order order)
        {
            return orderDL.AddOrder(order);
        }
        public int UpdateOrder(Order order)
        {
            return orderDL.UpdateOrder(order);
        }
    }
}
