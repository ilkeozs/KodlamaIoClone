using KodlamaIoClone.Entities;
using Business.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoClone.Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetAll();
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
        Course GetById(int id);
    }
}