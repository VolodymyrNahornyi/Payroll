using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class Country
    {
        [Column("CountryId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Employee country name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the country name is 30 characters.")]
        public string CountryName { get; set; }
    }
}