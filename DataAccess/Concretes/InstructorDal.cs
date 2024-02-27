using KodlamaIoClone.DataAccess.Abstracts;
using KodlamaIoClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoClone.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {

            _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, FirstName = "Engin",LastName = "Demiroğ" },
                new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı" },
            };
        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in _instructors)
            {
                Console.WriteLine($"ID: {instructor.Id}, Name: {instructor.FirstName}, Surname: {instructor.LastName}");
            }

            return _instructors;
        }



        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }



        public void Delete(int id)
        {
            Instructor instructorToDelete = _instructors.FirstOrDefault(i => i.Id == id);
            if (instructorToDelete != null)
            {
                _instructors.Remove(instructorToDelete);
            }
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = instructor.FirstName;
                instructorToUpdate.LastName = instructor.LastName;
                instructorToUpdate.CourseId = instructor.CourseId;
            }
            else
            {
                Console.WriteLine("The update could not be completed because the instructor with the ID number you entered does not exist!");
            }
        }

        public Instructor GetById(int id)
        {
            return _instructors.Find(x => x.Id == id);
        }
    }
}