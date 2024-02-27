using Business.Concretes;
using DataAccess.Concretes;
using KodlamaIoClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int courseId);
        Course GetById(int id);
        List<Course> GetAll();
    }
}