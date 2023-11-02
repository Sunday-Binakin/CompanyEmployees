using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComapnyEmployees.Models;

public class Company
{
    [Column("CompanyId")]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Company Name is a require field")]
    [MaxLength(60,ErrorMessage = "Maximum Length for the Name is 60 Characters")]
    public string?Name { get; set; }
    
    [Required(ErrorMessage = "Company Address is a require field")]
    [MaxLength(60,ErrorMessage = "Maximum Length for the Address is 60 Characters")]
    public string?Address { get; set; }
    
    public string? Country { set; get; }
    public ICollection<Employee>? Employees { get; set; }
}