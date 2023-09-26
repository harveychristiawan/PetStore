using PetStore.Factory;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Repository
{
    public class ProductRepository
    {
        private static PetDatabaseEntities db = DatabaseSingleton.GetInstance();
        // view album by artist id
        public static List<Product> GetProductByCategoryId(int categoryId)
        {
            return (from al in db.Products where al.CategoryID == categoryId select al).ToList();
        }

        // insert, delete, update
        public static void CreateProduct(Category category, String name, String desc, int price, int stock, String image)
        {
            Product product = ProductFactory.CreateProduct(category, name, image, price, stock, desc);
            db.Products.Add(product);
            db.SaveChanges();
        }

        public static Product GetProductById(int productId)
        {
            return (from al in db.Products where al.ProductID == productId select al).FirstOrDefault();
        }

        public static bool UpdateProduct(int productId, String name, String desc, int price, int stock, String image)
        {
            Product product = GetProductById(productId);
            if (product != null)
            {
                product.ProductName = name;
                product.ProductDescription = desc;
                product.ProductPrice = price;
                product.ProductStock = stock;
                product.ProductImage = image;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateProductStock(int productId, int qtyBought)
        {
            Product product = GetProductById(productId);
            if (product != null)
            {
                product.ProductStock = product.ProductStock - qtyBought;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveProduct(int productId)
        {
            Product product = GetProductById(productId);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveProductByCategory(List<Product> product)
        {
            if (product != null)
            {
                db.Products.RemoveRange(product);
                db.SaveChanges();
                return true;
            }
            return false;


        }
    }
}