using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite_v2.Models
{
	public class Skill
	{
		[Key]
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public int Percent { get; set; }
	}
}
