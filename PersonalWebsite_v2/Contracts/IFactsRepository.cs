using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Contracts
{
	public interface IFactsRepository
	{

		Fact GetFacts(bool trackChanges);
		void UpdateFacts(Fact fact);


	}
}
