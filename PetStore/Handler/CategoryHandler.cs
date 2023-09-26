using PetStore.Model;
using PetStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Handler
{
    public class CategoryHandler
    {
        public static List<Category> GetAllCategory()
        {
            List<Category> categories = CategoryRepository.GetAllCategory();
            return categories;
        }

        public static void CreateCategory(String name, String image)
        {
            CategoryRepository.CreateCategory(name, image);
        }

        public static Category GetCategoryById(int id)
        {
            return CategoryRepository.GetCategoryById(id);
        }

        public static bool RemoveCategory(int id)
        {

            Category a = GetCategoryById(id);
            if (a.Products.Count > 0)
            {
                ProductRepository.RemoveProductByCategory(a.Products.ToList());
            }
            return CategoryRepository.RemoveCategory(id);
        }

        public static bool UpdateCategory(int id, String name, String image)
        {
            return CategoryRepository.UpdateCategory(id, name, image);
        }

        public static bool CheckCategoryNameUnique(String name)
        {
            return CategoryRepository.CheckCategoryNameUnique(name);
        }
    }
}