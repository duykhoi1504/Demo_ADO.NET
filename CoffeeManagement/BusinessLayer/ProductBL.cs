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
    public class ProductBL
    {
        private ProductDL productDL;

        public ProductBL()
        {
            productDL = new ProductDL();
        }

        public List<Product> GetProducts()
        {
            try
            {
                return productDL.GetProducts();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int AddProduct(Product p)
        {
            try
            {
                return productDL.AddProduct(p);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Product> GetProductsByCategory(int categoryID)
        {
            try
            {
                return productDL.GetProductsByCategory(categoryID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
