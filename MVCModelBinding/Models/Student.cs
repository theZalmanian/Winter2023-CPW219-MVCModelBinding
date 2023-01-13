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
        public string FirstName { get; set; }

        /// <summary>
        /// The student's legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The student's date of birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }
    }
}
