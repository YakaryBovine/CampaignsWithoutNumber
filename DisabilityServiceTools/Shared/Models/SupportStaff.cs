using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Shared.Models
{
    public partial class SupportStaff
    {
        public SupportStaff()
        {
            ExamArrangement = new HashSet<ExamArrangement>();
            TestArrangement = new HashSet<TestArrangement>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<ExamArrangement> ExamArrangement { get; set; }
        public virtual ICollection<TestArrangement> TestArrangement { get; set; }
    }
}
