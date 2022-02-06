using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Shared.Models
{
  public partial class Student
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "Surname is required.")]
    public string Surname { get; set; }
    [Required(ErrorMessage = "First name is required.")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Student ID is required.")]
    [RegularExpression(@"^(\d{9})$", ErrorMessage = "Student ID must be a 9 digit number")]
    public int? StudentId { get; set; }
  }
}