using PersonalWebsite_v2.Contracts;

namespace PersonalWebsite_v2.Repository
{
	public class RepositoryManager : IRepositoryManager
	{
		private RepositoryContext _repositoryContext;
		private IPersonalInfoRepository _personalInfoRepository;
		private IFactsRepository _factsRepository;
		private ISkillsRepository _skillsRepository;
		private ISpecialitiesRepository _specialitiesRepository;
		private IMusicsRepository _musicsRepository;

		public RepositoryManager(RepositoryContext repositoryContext, IPersonalInfoRepository personalInfoRepository,
			IFactsRepository factsRepository, ISkillsRepository skillsRepository,
			ISpecialitiesRepository specialitiesRepository, IMusicsRepository musicsRepository)
		{
			_repositoryContext = repositoryContext;
			_specialitiesRepository = specialitiesRepository;
			_musicsRepository = musicsRepository;
		}

		public IPersonalInfoRepository PersonalInfos
		{
			get
			{
				if(_personalInfoRepository == null )
					_personalInfoRepository = new PersonalInfoRepository(_repositoryContext);
				return _personalInfoRepository;
			}
		}

		public IFactsRepository Facts
		{
			get
			{
				if(_factsRepository == null)
					_factsRepository = new FactsRepository(_repositoryContext);
				return _factsRepository;
			}
		}

		public ISkillsRepository Skills
		{
			get
			{
				if (_skillsRepository == null)
					_skillsRepository = new SkillsRepository(_repositoryContext);
				return (_skillsRepository);
			}
		}

		public ISpecialitiesRepository Specialities
		{
			get
			{
				if (_specialitiesRepository == null)
					_specialitiesRepository = new SpecialitiesRepository(_repositoryContext);
				return (_specialitiesRepository);
			}
		}

		public IMusicsRepository Musics
		{
			get
			{
				if (_musicsRepository == null)
					_musicsRepository = new MusicsRepository(_repositoryContext);
				return (_musicsRepository);
			}
		}

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
