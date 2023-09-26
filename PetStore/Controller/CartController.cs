using PetStore.Handler;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Controller
{
    public class CartController
    {
        public static String validateCart(int qty, int productStock)
        {
            String response = "";
            // validate qty
            if (qty == -1)
            {
                response = "Quantity must be filled";
            }
            else if (qty > productStock)
            {
                response = "Quantity cant be more than the stock product";
            }
            return response;
        }

        public static void AddItemToCart(Customer cust, Product alb, int qty)
        {
            CartHandler.CreateCart(cust, alb, qty);
        }

        public static bool CheckOut(int customerId)
        {
            return CartHandler.CheckOut(customerId);
        }

        public static List<object> GetAllCartByCustomerId(int customerId)
        {
            return CartHandler.GetAllCartByCustomerId(customerId);
        }

        // remove individual data in cart
        public static bool RemoveOneCart(int customerId, int productId)
        {
            return CartHandler.RemoveOneCart(customerId, productId);
        }

        // find cart by customer id and product id
        public static Cart GetCartByCustomerAndproduct(int customerId, int productId)
        {
            return CartHandler.GetCartByCustomerAndproduct(customerId, productId);
        }
    }
}