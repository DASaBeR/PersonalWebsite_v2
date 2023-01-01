using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class SkillsRepository : RepositoryBase<Skill> , ISkillsRepository
	{
		public SkillsRepository(RepositoryContext repositoryContext):base(repositoryContext)
		{

		}

		public void AddEdu(Skill skill)
		{
			throw new NotImplementedException();
		}

		public void DeleteEdu(Skill skill)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Skill> GetEducations(bool trackChanges)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdu(Skill skill)
		{
			throw new NotImplementedException();
		}
	}
}
