using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite_v2.Models
{
	public class Music
	{
		public Guid Id { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Link { get; set; }
	}
}
