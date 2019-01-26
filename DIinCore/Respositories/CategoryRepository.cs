using System.Collections.Generic;

namespace DIinCore
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            Category category = new Category() { CategoryId = 1, CategoryName = "Category1" };
            categories.Add(category);

            category = new Category() { CategoryId = 2, CategoryName = "Category2" };
            categories.Add(category);

            return categories;
        }
    }
}
