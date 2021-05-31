using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class JobTitleHistory
    {
        [Column("JobTitleHistoryId")]
        public Guid Id { get; set; }
        
        [ForeignKey(nameof(JobTitle))]
        public Guid JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
        
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        [Required(ErrorMessage = "Employee employment start date is a required field.")]
        public DateTime StartDate { get; set; }
        
        [Required(ErrorMessage = "Employee employment end date is a required field.")]
        public DateTime EndDate { get; set; }
    }
}