using PetStore.Model;
using PetStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Handler
{
    public class ProductHandler
    {
        public static List<Product> GetProductByCategoryId(int categoryId)
        {
            return ProductRepository.GetProductByCategoryId(categoryId);
        }

        // insert, delete, update
        public static void CreateProduct(Category category, String name, String desc, int price, int stock, String image)
        {
            ProductRepository.CreateProduct(category, name, desc, price, stock, image);
        }

        public static Product GetProductById(int productId)
        {
            return ProductRepository.GetProductById(productId);
        }

        public static bool UpdateProduct(int productId, String name, String desc, int price, int stock, String image)
        {
            return ProductRepository.UpdateProduct(productId, name, desc, price, stock, image);
        }

        public static bool RemoveProduct(int productId)
        {
            return ProductRepository.RemoveProduct(productId);
        }
    }
}