using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Contracts
{
	public interface ISkillsRepository
	{
		IEnumerable<Skill> GetEducations(bool trackChanges);
		void AddEdu(Skill skill);
		void UpdateEdu(Skill skill);
		void DeleteEdu(Skill skill);
	}
}
