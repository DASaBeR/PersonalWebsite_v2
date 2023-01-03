using PersonalWebsite_v2.Models;

namespace PersonalWebsite_v2.Contracts
{
	public interface IMusicsRepository
	{
		IEnumerable<Music> GetMusics(bool trackChanges);
		void AddMusic(Music music);
		void UpdateMusic(Music music);
		void DeleteMusic(Music music);
	}
}
