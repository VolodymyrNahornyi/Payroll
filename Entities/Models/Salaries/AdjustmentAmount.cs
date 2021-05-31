using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Employees;

namespace Entities.Models.Salaries
{
    public class AdjustmentAmount
    {
        [Column("AdjustmentAmountId")] 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Adjustment Amount Value is a required field.")]
        public decimal AdjustmentAmountValue { get; set; }
        
        [Required(ErrorMessage = "Adjustment Percentage Value is a required field.")]
        public decimal AdjustmentPercentageValue { get; set; }
        
        [ForeignKey(nameof(SalaryPayment))] 
        public Guid SalaryPaymentId { get; set; }
        public SalaryPayment SalaryPayment { get; set; }
        
        [ForeignKey(nameof(Adjustment))] 
        public Guid AdjustmentId { get; set; }
        public Adjustment Adjustment { get; set; }
    }
}