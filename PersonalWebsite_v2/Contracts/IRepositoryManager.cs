namespace PersonalWebsite_v2.Contracts
{
	public interface IRepositoryManager
	{
		IPersonalInfoRepository PersonalInfoRepository { get; }
		IFactsRepository FactsRepository { get; }
		ISkillsRepository SkillsRepository { get; }
		void Save();
	}
}
