using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite_v2.Models
{
	public class Music
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Link { get; set; }
	}
}
