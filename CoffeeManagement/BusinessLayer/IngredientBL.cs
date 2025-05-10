using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class IngredientBL
    {
        public IngredientDL ingredientDL;

        public IngredientBL()
        {
            ingredientDL = new IngredientDL();
        }

        public List<Ingredient> GetIngredients()
        {
            try
            {
                return ingredientDL.GetIngredients();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Ingredient GetIngredient(string id)
        {
            try
            {
                return ingredientDL.GetIngredient(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int AddIngredient(Ingredient i)
        {
            try
            {
                return ingredientDL.AddIngredient(i);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateIngredient(Ingredient i)
        {
            try
            {
                return ingredientDL.UpdateIngredient(i);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteIngredient(string id)
        {
            if (ingredientDL.HasTransaction(id))
            {
                throw new Exception("Cannot delete ingredient that have transaction.");
            }
            try
            {
                return ingredientDL.DeleteIngredient(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex2){
                throw ex2;
            }
        }

        public bool IsIngredientIDExists(string id)
        {
            var ings = GetIngredients();
            return ings.Any(i => i.id == id);
        }

        public List<Ingredient> GetIngredientsBySupplier(string supplierID)
        {
            return ingredientDL.GetIngredientsBySupplier(supplierID);
        }

        public List<Ingredient> GetIngredientsByStatus(string status)
        {
            return ingredientDL.GetIngredientsByStatus(status);
        }
    }
}
