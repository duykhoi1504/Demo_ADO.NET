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
    public  class OrderBL
    {
        private OrderDL orderDL;
        public OrderBL()
        {
            orderDL = new OrderDL();
        }
        public Order GetOrderByID(int id)
        {
            try
            {
                return orderDL.GetOrderByID(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Order> GetOrders()
        {
            try
            {
                return orderDL.GetOrders();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int AddOrder(Order order)
        {
            try
            {
                return orderDL.AddOrder(order);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateOrder(Order order)
        {
            try
            {
                return orderDL.UpdateOrder(order);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
