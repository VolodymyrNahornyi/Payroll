using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Employees;

namespace Entities.Models.Salaries
{
    public class WorkingHoursLog
    {
        [Column("WorkingHoursLogId")] 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Employee start working time is a required field.")]
        public DateTime StartTime { get; set; }
        
        [Required(ErrorMessage = "Employee end working time is a required field.")]
        public DateTime EndTime { get; set; }
        
        [ForeignKey(nameof(Employee))] 
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public ICollection<WorkingHoursAdjustment> WorkingHoursAdjustments { get; set; }
    }
}