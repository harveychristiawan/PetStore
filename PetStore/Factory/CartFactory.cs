using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(Customer customer, Product product, int qty)
        {
            Cart cart = new Cart();
            cart.Customer = customer;
            cart.Product = product;
            cart.Qty = qty;
            return cart;
        }
    }
}