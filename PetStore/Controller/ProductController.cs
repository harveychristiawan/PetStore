using PetStore.Handler;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Controller
{
    public class ProductController
    {
        public static String validateProduct(String name, String desc, int price, int stock, String imagePath, bool fileExists, int fileSize, String fileExt)
        {
            String response = "";
            // validasi name, desc, price, stock, img
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(desc) || price == 0 || stock == 0 || fileExists == false)
            {
                response = "All data must be filled";
            }
            else if (name.Length >= 50)
            {
                response = "Name length must be shorter than 50 characters";
            }
            else if (desc.Length >= 255)
            {
                response = "Description length must be shorter than 255 characters";
            }
            else if (price < 100000 || price > 1000000)
            {
                response = "Price must be between 100000 and 1000000";
            }
            else if (stock <= 0)
            {
                response = "Stock must be more than 0";
            }
            else if (fileExists == false)
            {
                response = "File must be chosen";
            }
            else
            {
                bool isValid = false;
                String[] validExt = { ".png", ".jpg", ".jpeg", ".jfif", ".PNG", ".JPG", ".JPEG", ".JFIF" };
                for (int i = 0; i < fileExt.Length; i++)
                {
                    if (fileExt.Equals(validExt[i]))
                    {
                        isValid = true;
                    }
                }

                if (isValid == false)
                {
                    response = "File extention must be .png, .jpg, .jpeg, .jfif";
                }
                else if (fileSize > 2048000)
                {
                    response = "File size must be lower than 2MB";
                }
            }
            return response;
        }

        public static void doInsertProduct(int categoryId, String name, String desc, int price, int stock, String image)
        {
            Category category = CategoryHandler.GetCategoryById(categoryId);
            ProductHandler.CreateProduct(category, name, desc, price, stock, image);
        }

        public static void doUpdateProduct(int ProductId, String name, String desc, int price, int stock, String image)
        {
            ProductHandler.UpdateProduct(ProductId, name, desc, price, stock, image);
        }

        public static List<Product> GetProductByCategoryId(int categoryId)
        {
            return ProductHandler.GetProductByCategoryId(categoryId);
        }


        public static Product GetProductById(int ProductId)
        {
            return ProductHandler.GetProductById(ProductId);
        }

        public static bool RemoveProduct(int ProductId)
        {
            return ProductHandler.RemoveProduct(ProductId);
        }
    }
}