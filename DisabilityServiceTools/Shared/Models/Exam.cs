using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Shared.Models
{
    public partial class Exam
    {
        public Exam()
        {
            ExamArrangement = new HashSet<ExamArrangement>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Course { get; set; }

        public virtual Course CourseNavigation { get; set; }
        public virtual ICollection<ExamArrangement> ExamArrangement { get; set; }
    }
}
