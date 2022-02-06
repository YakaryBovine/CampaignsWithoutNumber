using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Shared.Models
{
    public partial class CourseStream
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? Crn { get; set; }
        public int? Trimester { get; set; }
        public int? Year { get; set; }

        public virtual Course Course { get; set; }
    }
}
