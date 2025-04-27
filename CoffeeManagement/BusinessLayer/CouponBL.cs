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
    public class CouponBL
    {
        private CouponDL couponDL;

        public CouponBL()
        {
            couponDL = new CouponDL();
        }

        public List<Coupon> GetCoupons()
        {
            try
            {
                return couponDL.GetCoupons();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int AddCoupon(Coupon c)
        {
            try
            {
                return couponDL.AddCoupon(c);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int UpdateCoupon(Coupon c)
        {
            try
            {
                return couponDL.UpdateCoupon(c);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int DeleteCoupon(string id)
        {
            try
            {
                return couponDL.DeleteCoupon(id);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool IsCouponIdExists(string id)
        {
            var coupons = GetCoupons();
            return coupons.Any(c => c.id == id);
        }
    }
}
