using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class EmploymentTerms
    {
        [Column("EmploymentTermsId")]
        public Guid Id { get; set; }
        
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        [Required(ErrorMessage = "Employee agreed salary is a required field.")]
        public decimal AgreedSalary { get; set; }
        
        [Required(ErrorMessage = "Employee salary start date is a required field.")]
        public DateTime SalaryStartDate { get; set; }
        
        [Required(ErrorMessage = "Employee salary end date is a required field.")]
        public DateTime SalaryEndDate { get; set; }
    }
}