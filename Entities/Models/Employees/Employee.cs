using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Employee first name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the First Name is 30 characters.")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Employee last name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Last Name is 30 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Employee date of birth is a required field.")]
        public DateTime DateOfBirth { get; set; }
        
        [ForeignKey(nameof(JobTitle))]
        public Guid JobTitleId { get; set; }
        
        [ForeignKey(nameof(Department))]
        public Guid DepartmentId { get; set; }
        
        [ForeignKey(nameof(Gender))]
        public Guid GenderId { get; set; }
        
        [Required(ErrorMessage = "Employee address is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the address is 50 characters.")]
        public string Address { get; set; }
        
        [ForeignKey(nameof(City))]
        public Guid CityId { get; set; }
        
        [Required(ErrorMessage = "Employee email is a required field.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Employee employment start is a required field.")]
        public DateTime EmploymentStart { get; set; }
        
    }
}