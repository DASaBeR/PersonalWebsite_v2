using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite_v2.Models.ViewModels
{
	public class PersonalInfoVM
	{
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? AboutMe { get; set; }
		[Required]
		public string? CityOfResidence { get; set; }
		public string? BirthDay { get; set; }
		[Required]
		public string? Age { get; set; }
		public string? Degree { get; set; }
		public string? Phone { get; set; }
		[Required]
		public string? Email { get; set; }
		public string? Telegram { get; set; }
		public string? WhatsApp { get; set; }
		public string? Instagram { get; set; }
		public string? Linkdin { get; set; }
		public string? Github { get; set; }
		public bool IsFreeLance { get; set; }
	}
}
