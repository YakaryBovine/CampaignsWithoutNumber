using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Shared.Models
{
  public partial class Test
  {
    public Test()
    {
      TestArrangement = new HashSet<TestArrangement>();
    }

    public int Id { get; set; }
    public int? CourseId { get; set; }
    [Required(ErrorMessage = "Date and time is required.")]
    public DateTime? DateTime { get; set; }
    [Required(ErrorMessage = "Duration is required.")]
    public int? Duration { get; set; }

    public virtual Course Course { get; set; }
    public virtual ICollection<TestArrangement> TestArrangement { get; set; }
  }
}
