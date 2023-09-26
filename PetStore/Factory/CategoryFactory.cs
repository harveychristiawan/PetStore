using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Factory
{
    public class CategoryFactory
    {
        public static Category CreateCategory(String categoryName, String categoryImage)
        {
            Category category = new Category();
            category.CategoryName = categoryName;
            category.CategoryImage = categoryImage;
            return category;
        }
    }
}