using PetStore.Model;
using PetStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Handler
{
    public class CartHandler
    {
        public static bool CheckOut(int customerId)
        {
            Customer customer = CustomerHandler.GetCustomerById(customerId);
            // hapus semua cart customer ini
            List<Cart> cart = CartRepository.GetAllCartByCustomerIdPure(customerId);

            TransactionHeader thLast = TransactionRepository.CreateTransactionHeader(customer);
            // TransactionHeader thLast = TransactionRepository.GetLatestTransactionByCustomer(customerId);

            if (thLast != null && cart.Count > 0)
            {
                foreach (Cart c in cart)
                {
                    Console.WriteLine("test");
                    TransactionRepository.CreateTransactionDetail(thLast, c.Product, c.Qty);
                    ProductRepository.UpdateProductStock(c.ProductID, c.Qty);
                }


                // delete all cart from this customer
                CartRepository.RemoveAllCartByCustomer(cart);
                return true;
            }
            else
            {
                return false;
            }

        }

        public static List<object> GetAllCartByCustomerId(int customerId)
        {
            return CartRepository.GetAllCartByCustomerId(customerId);
        }

        // add cart
        public static void CreateCart(Customer cust, Product alb, int qty)
        {
            // search by cust and alb first
            Cart item = GetCartByCustomerAndproduct(cust.CustomerID, alb.ProductID);
            // if exist, add the qty to the item
            if (item != null)
            {
                // update the cart qty
                CartRepository.UpdateCartQuantity(item, qty);
            }
            else
            {
                // if not exist, create new item to cart
                CartRepository.CreateCart(cust, alb, qty);
            }

        }


        // remove individual data in cart
        public static bool RemoveOneCart(int customerId, int productId)
        {
            return CartRepository.RemoveOneCart(customerId, productId);
        }

        // find cart by customer id and product id
        public static Cart GetCartByCustomerAndproduct(int customerId, int productId)
        {
            return CartRepository.GetCartByCustomerAndproduct(customerId, productId);
        }
    }
}