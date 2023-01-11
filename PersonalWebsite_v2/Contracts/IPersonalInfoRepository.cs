using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Contracts
{
	public interface IPersonalInfoRepository
	{
		PersonalInfo GetPersonalInfo(bool trackChanges);
		void UpdatePersonalInfo(PersonalInfo personalInfo);
	}
}
