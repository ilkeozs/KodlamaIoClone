using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoClone.Entities
{
    public class Course : BaseEntity
    {
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseInstructor { get; set; }
        public double CoursePrice { get; set; }
    }
}