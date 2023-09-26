using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Factory
{
    public class ProductFactory
    {
        public static Product CreateProduct(Category category, String productName, String productImage, int productPrice, int productStock, String productDescription)
        {
            Product product = new Product();
            product.Category = category;
            product.ProductName = productName;
            product.ProductImage = productImage;
            product.ProductPrice = productPrice;
            product.ProductStock = productStock;
            product.ProductDescription = productDescription;
            return product;
        }
    }
}