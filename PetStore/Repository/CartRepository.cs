using PetStore.Factory;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Repository
{
    public class CartRepository
    {
        private static PetDatabaseEntities db = DatabaseSingleton.GetInstance();

        // show cart
        public static List<object> GetAllCartByCustomerId(int customerId)
        {
            var result = (from ca in db.Carts
                          join al in db.Products on ca.ProductID equals al.ProductID
                          where ca.CustomerID == customerId
                          orderby al.ProductID
                          select new { al.ProductID, al.ProductImage, al.ProductName, al.ProductPrice, ca.Qty }).ToList();
            return result.Cast<object>().ToList();
        }

        public static List<Cart> GetAllCartByCustomerIdPure(int customerId)
        {
            return (from ca in db.Carts
                    where ca.CustomerID == customerId
                    select ca).ToList();
        }

        // add cart
        public static void CreateCart(Customer cust, Product alb, int qty)
        {
            Cart cart = CartFactory.CreateCart(cust, alb, qty);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        // remove all cart by customer
        public static bool RemoveAllCartByCustomer(List<Cart> cartList)
        {
            if (cartList != null)
            {
                db.Carts.RemoveRange(cartList);
                db.SaveChanges();
                return true;
            }
            return false;

        }

        // remove individual data in cart
        public static bool RemoveOneCart(int customerId, int productId)
        {
            Cart cart = GetCartByCustomerAndproduct(customerId, productId);
            if (cart != null)
            {
                db.Carts.Remove(cart);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // find cart by customer id and product id
        public static Cart GetCartByCustomerAndproduct(int customerId, int productId)
        {
            return (from ca in db.Carts where ca.ProductID == productId && ca.CustomerID == customerId select ca).FirstOrDefault();
        }

        // update cart quantity
        public static bool UpdateCartQuantity(Cart item, int newQty)
        {
            if (item != null)
            {
                item.Qty = newQty;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}