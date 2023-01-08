using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class FactsRepository : RepositoryBase<Fact> , IFactsRepository
	{

		public FactsRepository(RepositoryContext repositoryContext):base(repositoryContext)
		{

		}
		public void AddFacts(Fact fact)
		{
			throw new NotImplementedException();
		}

		public void DeleteFacts(Fact fact)
		{
			throw new NotImplementedException();
		}

		public Fact GetFacts(bool trackChanges) =>
			FindAll(trackChanges).FirstOrDefault();

		public void UpdateFacts(Fact fact)
		{
			throw new NotImplementedException();
		}


	}
}
