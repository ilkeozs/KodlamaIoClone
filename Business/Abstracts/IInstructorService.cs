using KodlamaIoClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoClone.Business.Abstracts
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        Instructor GetById(int id);
        void Delete(int id);
    }
}