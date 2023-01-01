using PersonalWebsite_v2.Contracts;

namespace PersonalWebsite_v2.Repository
{
	public class RepositoryManager : IRepositoryManager
	{
		private RepositoryContext _repositoryContext;
		private IPersonalInfoRepository _personalInfoRepository;
		private IFactsRepository _factsRepository;
		private ISkillsRepository _skillsRepository;

		public RepositoryManager(RepositoryContext repositoryContext, IPersonalInfoRepository personalInfoRepository, IFactsRepository factsRepository, ISkillsRepository skillsRepository)
		{
			_repositoryContext = repositoryContext;
		}

		public IPersonalInfoRepository PersonalInfoRepository
		{
			get
			{
				if(_personalInfoRepository == null )
					_personalInfoRepository = new PersonalInfoRepository(_repositoryContext);
				return _personalInfoRepository;
			}
		}

		public IFactsRepository FactsRepository
		{
			get
			{
				if(_factsRepository == null)
					_factsRepository = new FactsRepository(_repositoryContext);
				return _factsRepository;
			}
		}

		public ISkillsRepository SkillsRepository
		{
			get
			{
				if (_skillsRepository == null)
					_skillsRepository = new SkillsRepository(_repositoryContext);
				return (_skillsRepository);
			}
		}

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
