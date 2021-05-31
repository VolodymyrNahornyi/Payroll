using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Employees;

namespace Entities.Models.Salaries
{
    public class Adjustment
    {
        [Column("AdjustmentId")] public Guid Id { get; set; }

        [Required(ErrorMessage = "Adjustment Name is a required field.")]
        public string AdjustmentName { get; set; }
        
        [Required(ErrorMessage = "Adjustment Percentage is a required field.")]
        public decimal AdjustmentPercentage { get; set; }
        
        [Required(ErrorMessage = "Is Working Hours Adjustment is a required field.")]
        public bool IsWorkingHoursAdjustment { get; set; }
        
        [Required(ErrorMessage = "Is Other Adjustment is a required field.")]
        public bool IsOtherAdjustment { get; set; }

        public ICollection<WorkingHoursAdjustment> WorkingHoursAdjustments { get; set; }
        public ICollection<AdjustmentAmount> AdjustmentAmounts { get; set; }
    }
}