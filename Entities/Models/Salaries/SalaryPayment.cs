using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Employees;

namespace Entities.Models.Salaries
{
    public class SalaryPayment
    {
        [Column("SalaryPaymentId")] 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Employee gross salary is a required field.")]
        public string GrossSalary { get; set; }

        [Required(ErrorMessage = "Employee net salary is a required field.")]
        public string NetSalary { get; set; }

        [Required(ErrorMessage = "Employee salary period is a required field.")]
        public DateTime SalaryPeriod { get; set; }
        
        [ForeignKey(nameof(Employee))] 
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        public ICollection<AdjustmentAmount> AdjustmentAmounts { get; set; }
        public WorkingHoursAdjustment WorkingHoursAdjustment { get; set; }
    }
}