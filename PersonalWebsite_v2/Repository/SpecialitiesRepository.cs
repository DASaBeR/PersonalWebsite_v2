﻿using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class SpecialitiesRepository : RepositoryBase<Speciality> , ISpecialitiesRepository
	{
		public SpecialitiesRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{

		}

		public void AddSpecialty(Speciality specialty)
		{
			throw new NotImplementedException();
		}

		public void DeleteSpecialty(Speciality specialty)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Speciality> GetSpecialities(bool trackChanges) =>
			FindAll(trackChanges).ToList();

		public void UpdateSpecialty(Speciality specialty)
		{
			throw new NotImplementedException();
		}
	}
}
