using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Repository
{
	public class MusicsRepository : RepositoryBase<Music> , IMusicsRepository
	{
		public MusicsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{

		}

		public void AddMusic(Music music)
		{
			throw new NotImplementedException();
		}

		public void DeleteMusic(Music music)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Music> GetMusics(bool trackChanges)
		{
			throw new NotImplementedException();
		}

		public void UpdateMusic(Music music)
		{
			throw new NotImplementedException();
		}
	}
}
