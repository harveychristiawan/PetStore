using PetStore.Factory;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Repository
{
    public class CategoryRepository
    {
        private static PetDatabaseEntities db = DatabaseSingleton.GetInstance();
        public static List<Category> GetAllCategory()
        {
            return (from a in db.Categories select a).ToList();
        }

        public static void CreateCategory(String name, String image)
        {
            Category a = CategoryFactory.CreateCategory(name, image);
            db.Categories.Add(a);
            db.SaveChanges();
        }

        public static Category GetCategoryById(int id)
        {
            return (from a in db.Categories where a.CategoryID == id select a).FirstOrDefault();
        }

        public static bool RemoveCategory(int id)
        {
            Category a = GetCategoryById(id);
            if (a != null)
            {
                db.Categories.Remove(a);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateCategory(int id, String name, String image)
        {
            Category a = GetCategoryById(id);
            if (a != null)
            {
                a.CategoryName = name;
                a.CategoryImage = image;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool CheckCategoryNameUnique(String name)
        {
            Category category = (from a in db.Categories where a.CategoryName == name select a).FirstOrDefault();
            if (category == null)
            {
                return true;
            }
            return false;
        }
    }
}