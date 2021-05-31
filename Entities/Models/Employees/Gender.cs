using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class Gender
    {
        [Column("GenderId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Employee gender is a required field.")]
        public string GenderName { get; set; }
    }
}