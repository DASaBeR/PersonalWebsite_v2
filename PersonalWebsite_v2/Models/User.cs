using Microsoft.AspNetCore.Identity;

namespace PersonalWebsite_v2.Models
{
	public class User : IdentityUser
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
	}
}
