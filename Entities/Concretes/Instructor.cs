using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoClone.Entities
{
    public class Instructor : BaseEntity
    {
        public List<int> CourseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}