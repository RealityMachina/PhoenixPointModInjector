namespace PhoenixPointModLoader
{
	public interface IPhoenixPointMod
	{
		ModLoadPriority Priority { get; }

		void Initialize();
	}
}