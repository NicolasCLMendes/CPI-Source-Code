// OfflineLastSessionCorruptionDetectedResult
using Disney.Mix.SDK;
using Disney.Mix.SDK.Internal;

public class OfflineLastSessionCorruptionDetectedResult : IOfflineLastSessionCorruptionDetectedResult, IInternalOfflineLastSessionResult, IOfflineLastSessionResult
{
	public bool Success
	{
		get;
		private set;
	}

	public ISession Session => InternalSession;

	public IInternalSession InternalSession
	{
		get;
		private set;
	}
}
