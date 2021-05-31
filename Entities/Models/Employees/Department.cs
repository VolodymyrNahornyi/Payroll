using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class Department
    {
        [Column("DepartmentId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Department Name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the department name is 30 characters.")]
        public string DepartmentName { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
        public ICollection<DepartmentHistory> DepartmentHistories { get; set; }
    }
}