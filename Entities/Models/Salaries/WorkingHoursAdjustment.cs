using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Employees;

namespace Entities.Models.Salaries
{
    public class WorkingHoursAdjustment
    {
        [Column("WorkingHoursAdjustmentId")] 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Employee adjustment amount is a required field.")]
        public int AdjustmentAmount { get; set; }
        
        [Required(ErrorMessage = "Employee adjustment percentage is a required field.")]
        public decimal AdjustmentPercentage { get; set; }
        
        [ForeignKey(nameof(WorkingHoursLog))] 
        public Guid WorkingHoursLogId { get; set; }
        public WorkingHoursLog WorkingHoursLog { get; set; }
        
        [ForeignKey(nameof(Adjustment))] 
        public Guid AdjustmentId { get; set; }
        public Adjustment Adjustment { get; set; }
        
        [ForeignKey(nameof(SalaryPayment))] 
        public Guid SalaryPaymentId { get; set; }
        public SalaryPayment SalaryPayment { get; set; }
    }
}