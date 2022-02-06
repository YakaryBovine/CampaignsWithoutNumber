using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Shared.Models
{
    public partial class ExamArrangement
    {
        public int Id { get; set; }
        public int Exam { get; set; }
        public int? ReaderWriter { get; set; }

        public virtual Exam ExamNavigation { get; set; }
        public virtual SupportStaff ReaderWriterNavigation { get; set; }
    }
}
