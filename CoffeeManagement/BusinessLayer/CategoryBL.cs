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
    public class CategoryBL
    {
        private CategoryDL categoryDL;

        public CategoryBL()
        {
            categoryDL = new CategoryDL();
        }

        public List<Category> GetCategories()
        {
            try
            {
                return categoryDL.GetCategories();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
