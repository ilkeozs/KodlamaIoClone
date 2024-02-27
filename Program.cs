using Business.Concretes;
using DataAccess.Concretes;
using KodlamaIoClone.DataAccess.Concretes;
using KodlamaIoClone.Entities;

internal class Program
{
    static void Main(string[] args)
    {
        CourseManager courseManager = new CourseManager(new CourseDal());
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        InstructorManager instructorManager = new InstructorManager(new InstructorDal());

        Console.ForegroundColor = ConsoleColor.Yellow;
        string title = @"  _  __         _ _                         _       
 | |/ /___   __| | | __ _ _ __ ___   __ _  (_) ___  
 | ' // _ \ / _` | |/ _` | '_ ` _ \ / _` | | |/ _ \ 
 | . \ (_) | (_| | | (_| | | | | | | (_| |_| | (_) |
 |_|\_\___/ \__,_|_|\__,_|_| |_| |_|\__,_(_)_|\___/ 
                                                    ";
        Console.WriteLine(title);
        Console.ResetColor();

        //All Courses
        Console.WriteLine("All Courses\n" + "-----------");
        courseManager.GetAll();

        //Adding a Course
        Course newCourse = new Course { Id = 4, CourseName = "New Course", CourseDescription = "Course description...", CategoryId = 1, CourseInstructor = "Sadık Turan" };
        courseManager.Add(newCourse);
        Console.WriteLine("\nNew course added!\n");
        courseManager.GetAll();

        //Course Update
        Course courseToUpdate = courseManager.GetById(4);
        courseToUpdate.CourseName = "Updated Course";
        courseToUpdate.CourseDescription = "Course description...";
        courseToUpdate.CategoryId = 1;
        courseToUpdate.CourseInstructor = "Atıl Samancıoğlu";
        courseManager.Update(courseToUpdate);
        Console.WriteLine("\nThe course has been updated!\n");
        courseManager.GetAll();

        //Delete a Course
        int courseIdToDelete = 4;
        courseManager.Delete(courseIdToDelete);
        Console.WriteLine($"\nCourse with ID {courseIdToDelete} has been deleted!\n");
        courseManager.GetAll();

        //All Categories
        Console.WriteLine("\nAll Categories\n" + "--------------");
        categoryManager.GetAll();

        //Add a Category
        Category newCategory = new Category { Id = 2, CategoryName = "Data Science" };
        categoryManager.Add(newCategory);
        Console.WriteLine("\nNew category added!\n");
        categoryManager.GetAll();

        //Category Update
        Category categoryToUpdate = categoryManager.GetById(2);
        categoryToUpdate.CategoryName = "Updated Category";
        categoryManager.Update(categoryToUpdate);
        Console.WriteLine("\nCategory updated!\n");
        categoryManager.GetAll();

        //Deleting a Category
        int categoryIdToDelete = 2;
        categoryManager.Delete(categoryIdToDelete);
        Console.WriteLine($"\nCategory with ID {categoryIdToDelete} has been deleted!\n");
        categoryManager.GetAll();

        //All Instructors
        Console.WriteLine("\nAll Instructors\n" + "---------------");
        instructorManager.GetAll();

        //Adding an Instructor
        Instructor newInstructor = new Instructor { Id = 3, FirstName = "Can", LastName = "Değer" };
        instructorManager.Add(newInstructor);
        Console.WriteLine("\nNew instructor added!\n");
        instructorManager.GetAll();

        //Instructor Update
        Instructor instructorToUpdate = instructorManager.GetById(3);
        instructorToUpdate.FirstName = "Mehmet";
        instructorToUpdate.LastName = "İnce";
        instructorManager.Update(instructorToUpdate);
        Console.WriteLine("\nInstructor updated!\n");
        instructorManager.GetAll();

        //Deleting an Instructor
        int instructorIdToDelete = 3;
        instructorManager.Delete(instructorIdToDelete);
        Console.WriteLine($"\nInstructor with ID {instructorIdToDelete} has been deleted!\n");
        instructorManager.GetAll();

        Console.ReadKey();
    }
}