using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Contracts
{
	public interface ISkillsRepository
	{
		IEnumerable<Skill> GetSkills(bool trackChanges);
		void AddSkill(Skill skill);
		void UpdateSkill(Skill skill);
		void DeleteSkill(Skill skill);
	}
}
