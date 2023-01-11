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
			Create(music);
		}

		public void DeleteMusic(Music music)
		{
			Delete(music);
		}

		public IEnumerable<Music> GetMusics(bool trackChanges) =>
			FindAll(trackChanges).ToList();

		public void UpdateMusic(Music music)
		{
			Update(music);
		}
	}
}
