using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Shared.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseStream = new HashSet<CourseStream>();
            Exam = new HashSet<Exam>();
            Test = new HashSet<Test>();
        }

        public int Id { get; set; }
        public string Code { get; set; }

        public virtual ICollection<CourseStream> CourseStream { get; set; }
        public virtual ICollection<Exam> Exam { get; set; }
        public virtual ICollection<Test> Test { get; set; }
    }
}
