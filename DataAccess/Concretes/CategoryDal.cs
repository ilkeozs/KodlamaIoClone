using KodlamaIoClone.Entities;
using KodlamaIoClone.DataAccess.Abstracts;
using KodlamaIoClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoClone.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {

            _categories = new List<Category>
            {
                new Category { Id = 1, CategoryName = "Programming" }

            };
        }

        public List<Category> GetAll()
        {
            foreach (var category in _categories)
            {
                Console.WriteLine($"Category Name: {category.CategoryName}");
            }

            return _categories;
        }



        public void Add(Category category)
        {
            _categories.Add(category);
        }



        public void Delete(int id)
        {
            Category categoryToDelete = _categories.FirstOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
            }
            else
            {
                Console.WriteLine("The update could not be completed because the category with the id number you entered does not exist!");
            }
        }

        public Category GetById(int id)
        {
            return _categories.Find(x => x.Id == id);
        }
    }
}