using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class JobTitle
    {
        [Column("JobTitleId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Employee job title is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Job Title is 30 characters.")]
        public string Title { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
        public ICollection<JobTitleHistory> JobTitleHistories { get; set; }
    }
}