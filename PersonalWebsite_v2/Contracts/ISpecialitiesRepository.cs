using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Contracts
{
	public interface ISpecialitiesRepository
	{
		IEnumerable<Specialty> GetSpecialities(bool trackChanges);
		void AddSpecialty(Specialty specialty);
		void UpdateSpecialty(Specialty specialty);
		void DeleteSpecialty(Specialty specialty);
	}
}
