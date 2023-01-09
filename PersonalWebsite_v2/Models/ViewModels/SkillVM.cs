using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite_v2.Models.ViewModels
{
	public class SkillVM
	{
		public Guid Id { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public int Percent { get; set; }
	}
}
