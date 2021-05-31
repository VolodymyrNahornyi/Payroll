using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Employees
{
    public class City
    {
        [Column("CityId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Employee city is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the city is 30 characters.")]
        public string CityName { get; set; }
        
        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
    }
}