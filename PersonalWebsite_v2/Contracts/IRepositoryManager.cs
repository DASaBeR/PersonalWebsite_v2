namespace PersonalWebsite_v2.Contracts
{
	public interface IRepositoryManager
	{

		IPersonalInfoRepository PersonalInfos { get; }
		IFactsRepository Facts { get; }
		ISkillsRepository Skills { get; }
		ISpecialitiesRepository Specialities { get; }
		IMusicsRepository Musics { get; }
		void Save();

	}
}
