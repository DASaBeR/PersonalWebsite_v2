using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite_v2.Models
{
	public class PersonalInfo
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string AboutMe { get; set; }
		public string CityOfResidence { get; set; }
		public string BirthDay { get; set; }
		public string Age { get; set; }
		public string Degree { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Telegram { get; set; }
		public string WhatsApp { get; set; }
		public string Instagram { get; set; }
		public string Linkdin { get; set; }
		public string Github { get; set; }
		public bool IsFreeLance { get; set; }

	}
}
