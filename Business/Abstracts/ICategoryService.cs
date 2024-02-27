using KodlamaIoClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoClone.Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        Category GetById(int id);
        void Update(Category category);
        void Delete(int id);
    }
}