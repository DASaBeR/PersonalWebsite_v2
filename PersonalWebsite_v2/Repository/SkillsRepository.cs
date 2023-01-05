using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class SkillsRepository : RepositoryBase<Skill> , ISkillsRepository
	{
		public SkillsRepository(RepositoryContext repositoryContext):base(repositoryContext)
		{

		}

		public void AddSkill(Skill skill)
		{
			throw new NotImplementedException();
		}

		public void DeleteSkill(Skill skill)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Skill> GetSkills(bool trackChanges) =>
			FindAll(trackChanges).ToList();

		public void UpdateSkill(Skill skill)
		{
			throw new NotImplementedException();
		}
	}
}
