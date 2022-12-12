using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Data.Model
{
	public class Resident
	{
        [Key]
        public int ResidentID { get; set; }
        [Required]
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string? Condition { get; set; }

        public Home? Home { get; set; }
        public int HomeID { get; set; }
    }
}

