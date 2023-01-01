using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Contracts
{
	public interface IFactsRepository
	{
		PersonalInfo GetFacts(bool trackChanges);
		void AddFacts(Fact fact);
		void UpdateFacts(Fact fact);
		void DeleteFacts(Fact fact);
	}
}
