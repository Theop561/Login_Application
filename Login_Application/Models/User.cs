using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Login_Application.Models
{
    public class User
    {
        [DefaultValue(0)]
        public int Id { get; set; } 
        [Required(ErrorMessage = "Please enter a valid email address")]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
