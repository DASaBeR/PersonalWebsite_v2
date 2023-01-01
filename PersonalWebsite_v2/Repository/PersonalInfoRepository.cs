using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class PersonalInfoRepository : RepositoryBase<PersonalInfo> , IPersonalInfoRepository
	{
		public PersonalInfoRepository(RepositoryContext repositoryContext):base(repositoryContext)
		{

		}
		public void AddPersonalInfo(bool trackChanges)
		{
			throw new NotImplementedException();
		}

		public PersonalInfo GetPersonalInfo(bool trackChanges)
		{
			throw new NotImplementedException();
		}

		public void RemovePersonalInfo(Guid id)
		{
			throw new NotImplementedException();
		}

		public void UpdatePersonalInfo(PersonalInfo personalInfo)
		{
			throw new NotImplementedException();
		}
	}
}
