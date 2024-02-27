using KodlamaIoClone.Entities;
using Business.Concretes;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {

        List<Course> courses;

        public CourseDal()
        {

            Course course1 = new Course();
            course1.CategoryId = 1;
            course1.Id = 1;
            course1.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course1.CourseDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını...";
            course1.CourseInstructor = "Engin Demiroğ";
            course1.CoursePrice = 0;

            Course course2 = new Course();
            course2.CategoryId = 1;
            course2.Id = 2;
            course2.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course2.CourseDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını...";
            course2.CourseInstructor = "Engin Demiroğ";
            course2.CoursePrice = 0;

            Course course3 = new Course();
            course3.CategoryId = 1;
            course3.Id = 3;
            course3.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course3.CourseDescription = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";
            course3.CourseInstructor = "Engin Demiroğ";
            course3.CoursePrice = 0;

            courses = new List<Course> { course1, course2, course3 };

        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int courseId)
        {
            Course courseToDelete = courses.FirstOrDefault(c => c.Id == courseId);
            if (courseToDelete != null)
            {
                courses.Remove(courseToDelete);
            }
        }

        public List<Course> GetAll()
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"Course Name: {course.CourseName}, Description: {course.CourseDescription}, Instructor: {course.CourseInstructor}");
            }

            return courses;
        }
        public Course GetById(int id)
        {
            return courses.Find(x => x.Id == id);
        }

        public void Update(Course course)
        {
            Course courseToUpdate = courses.FirstOrDefault(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {

                courseToUpdate.CourseName = course.CourseName;
                courseToUpdate.CourseDescription = course.CourseDescription;
                courseToUpdate.CoursePrice = course.CoursePrice;
                courseToUpdate.CategoryId = course.CategoryId;
                courseToUpdate.CourseInstructor = course.CourseInstructor;
            }
            else
            {
                Console.WriteLine("The update could not be completed because the course ID number you entered does not exist!");
            }

        }

    }
}