using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace Fyk.Tfs.TfsCommonControls
{
	public interface IMasterFormHandler
	{
		void WindowMsg(WorkItem workItem, MsgTypes msgType);
	}

	public enum MsgTypes
	{
		Nothing,
		Close,
		ChangeAndClose
	}
}
