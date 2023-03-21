using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models
{
	public class ExternalLoginConfirmationVM
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		public string Name { get; set; }
	}
}
