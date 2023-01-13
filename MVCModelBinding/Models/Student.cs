using System.ComponentModel.DataAnnotations;

namespace MVCModelBinding.Models
{
    /// <summary>
    /// Represents an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The student's legal first name
        /// </summary>
        [Required(ErrorMessage = "First name is required!")]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        /// <summary>
        /// The student's legal last name
        /// </summary>
        [Required(ErrorMessage = "Last name is required!")]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        /// <summary>
        /// The student's date of birth
        /// </summary>
        [Required(ErrorMessage = "Date of birth is required!")]
        [Display(Name = "Date of Birth:")]
        public DateOnly DateOfBirth { get; set; }
    }
}
