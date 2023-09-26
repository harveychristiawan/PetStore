using PetStore.Handler;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Controller
{
    public class CategoryController
    {
        public static String validateCategory(String name, String imagePath, bool fileExists, int fileSize, String fileExt)
        {
            String response = "";
            // validasi name, img
            if (string.IsNullOrWhiteSpace(name))
            {
                response = "Category name must be filled";
            }

            else if (CategoryHandler.CheckCategoryNameUnique(name) == false)
            {
                response = "Category name must be unique";
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

        public static void doInsertCategory(String name, String image)
        {
            CategoryHandler.CreateCategory(name, image);
        }

        public static void doUpdateCategory(int id, String name, String image)
        {
            CategoryHandler.UpdateCategory(id, name, image);
        }

        public static List<Category> GetAllCategory()
        {
            return CategoryHandler.GetAllCategory();
        }

        public static bool RemoveCategory(int id)
        {
            return CategoryHandler.RemoveCategory(id);
        }

        public static Category GetCategoryById(int id)
        {
            return CategoryHandler.GetCategoryById(id);
        }
    }
}