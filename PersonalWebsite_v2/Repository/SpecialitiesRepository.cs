using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class SpecialitiesRepository : RepositoryBase<Specialty> , ISpecialitiesRepository
	{
		public SpecialitiesRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{

		}

		public void AddSpecialty(Specialty specialty)
		{
			throw new NotImplementedException();
		}

		public void DeleteSpecialty(Specialty specialty)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Specialty> GetSpecialities(bool trackChanges) =>
			FindAll(trackChanges).ToList();

		public void UpdateSpecialty(Specialty specialty)
		{
			throw new NotImplementedException();
		}
	}
}
