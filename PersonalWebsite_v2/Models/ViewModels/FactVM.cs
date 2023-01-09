using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite_v2.Models.ViewModels
{
	public class FactVM
	{
		[Required]
		public int HappyClient { get; set; }
		[Required]
		public int Projects { get; set; }
		[Required]
		public int HoursOfSupport { get; set; }
		[Required]
		public int Awards { get; set; }
	}
}
