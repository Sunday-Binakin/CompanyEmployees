using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComapnyEmployees.Models;

public class Employee
{
    [Column("EmployeeId")]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Employee Name is a require field")]
    [MaxLength(30,ErrorMessage = "Maximum Length for the Name is 30 Characters")]
    public string?Name { get; set; }
    
    [Required(ErrorMessage = "Age is a require field")]
    public string?Age { get; set; }
    
   
    [Required(ErrorMessage = "Employee Name is a require field")]
    [MaxLength(20,ErrorMessage = "Maximum Length for the position is 20 Characters")]
    public string?Position { get; set; }
    
    [ForeignKey(nameof(Company))]
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }
}