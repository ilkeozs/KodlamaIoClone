using KodlamaIoClone.Business.Abstracts;
using KodlamaIoClone.DataAccess.Abstracts;
using KodlamaIoClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.GetById(id);
        }
    }
}