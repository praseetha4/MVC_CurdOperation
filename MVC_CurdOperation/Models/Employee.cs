using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CurdOperation.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date of Birth.")]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [DisplayName("Mobile No")]
        [Required(ErrorMessage = "Mobile Number Required")]
        [Phone(ErrorMessage = "Invalid Mobile No")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Age is required.")]
        [Range(18, 99, ErrorMessage = "Age must be between 18 and 60.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        public string position { get; set; }

        
        [DisplayName("Date Of Hire")]
        [Required(ErrorMessage = "Date of Hire is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date of Hire.")]
        public string DateOfHire { get; set; }
        [Required(ErrorMessage = "Department is required.")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Salary is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Salary must be greater than 0.")]
        public double Salary { get; set; }
    }
}