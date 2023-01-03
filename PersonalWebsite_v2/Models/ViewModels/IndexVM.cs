namespace PersonalWebsite_v2.Models.ViewModels
{
	public class IndexVM
	{
		public PersonalInfo PersonalInfo { get; set; }
		public Fact Fact { get; set; }
		public IEnumerable<Specialty> Specialties { get; set; }
		public IEnumerable<Skill> Skills { get; set; }
		public IEnumerable<Music> Musics { get; set; }
	}
}
