using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login_Application.Models
{
	public class RegisterViewModel 
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
		public string? FirstName { get; set; }
		[Required]
		public string? LastName { get; set; }
		[Required]
		[EmailAddress]
		public string? Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string? Password { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage ="not match")]
		public string? ConfirmPassword { get; set; }
	}
}
