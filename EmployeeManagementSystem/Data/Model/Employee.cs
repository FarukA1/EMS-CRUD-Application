using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Data.Model
{
	public class Employee
	{
        [Key]
        public int EmpID { get; set; }
        [Required]
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public Gender Gender { get; set; }
        public string? Email { get; set; }
        [Required]
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
        public string? Nationality { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public string? EmploymentStatus { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}

