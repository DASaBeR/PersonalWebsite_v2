using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class PersonalInfoRepository : RepositoryBase<PersonalInfo> , IPersonalInfoRepository
	{
		public PersonalInfoRepository(RepositoryContext repositoryContext):base(repositoryContext)
		{

		}

		public PersonalInfo GetPersonalInfo(bool trackChanges) =>
			FindAll(trackChanges).FirstOrDefault();

		public void UpdatePersonalInfo(PersonalInfo personalInfo)
		{
			Update(personalInfo);
		}
	}
}
