using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Data.Model
{
	public class Home
	{
        [Key]
        public int HomeID { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        [Required]
        public string? HouseName { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? PostCode { get; set; }
        public string? County { get; set; }
        [Required]
        public string? City { get; set; }

        public List<Resident>? Residents { get; set; }
    }
}

