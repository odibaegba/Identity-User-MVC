using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models
{
	public class ForgotPasswordVM
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}
}
