using System.ComponentModel.DataAnnotations;

namespace LetsConnect.Models.UserRegistration
{
    public class UserDetails
    {
		public UserDetails() 
		{ 
			UserLoginId = string.Empty;
			UserPassword = string.Empty;
			FirstName = string.Empty;
			MiddleName = string.Empty;
			LastName = string.Empty;
			Email = string.Empty;
			PhoneNo = string.Empty;
            //DOB = DateOnly.FromDateTime(DateTime.Today);
            Gender = string.Empty;
		}
        [Required(ErrorMessage = "The User Id field is required.")]
        public string UserLoginId { get; set; }

        [Required(ErrorMessage = "The password field is required.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "The password field must be a string with a minimum length of 8.")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "The First name field is required.")]
        [StringLength(50, ErrorMessage = "The FirstName field must be a string with a maximum length of 50.")]
        public string FirstName { get; set; }
		public string MiddleName { get; set; }

        [Required(ErrorMessage = "The Last name field is required.")]
        [StringLength(50, ErrorMessage = "The Last name field must be a string with a maximum length of 50.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [StringLength(50, ErrorMessage = "The Email field must be a string with a maximum length of 50.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Phone field is required.")]
        [StringLength(15, ErrorMessage = "The Phone field must be a string with a maximum length of 15.")]
        public string PhoneNo { get; set; }

        public string Gender { get; set; }
        public bool IsDelete { get; set; }
        //public DateOnly DOB { get; set; }
    }
}
