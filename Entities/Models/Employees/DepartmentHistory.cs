using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class DepartmentHistory
    {
        [Column("DepartmentHistoryId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Employee department start date is a required field.")]
        public DateTime StartDate { get; set; }
        
        [Required(ErrorMessage = "Employee department end date is a required field.")]
        public DateTime EndDate { get; set; }
        
        [ForeignKey(nameof(Department))]
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}