using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Contracts
{
	public interface ISpecialitiesRepository
	{
		IEnumerable<Speciality> GetSpecialities(bool trackChanges);
		void AddSpecialty(Speciality specialty);
		void UpdateSpecialty(Speciality specialty);
		void DeleteSpecialty(Speciality specialty);
	}
}
