using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace PersonalWebsite_v2.Models
{
	public class Fact
	{
		[Key]
		public Guid Id { get; set; }
		public int HappyClient { get; set; }
		public int Projects { get; set; }
		public int HoursOfSupport { get; set; }
		public int Awards { get; set; }
	}
}
