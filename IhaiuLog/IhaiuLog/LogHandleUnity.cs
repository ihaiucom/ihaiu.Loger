#if UNITY
using System;
using System.Text;
using UnityEngine;

namespace ihaiu.logs
{
	public class LogHandleUnity : AbstractLogHandle
	{
		protected override void Print (LogType logType, object tag, object message, string stackTrack = null)
		{
			StringBuilder sb = GetStringBuilder();
			sb.Append ("\t");
			sb.Append (logType);
			sb.Append ("\t");
			sb.Append (tag);
			sb.Append ("\t");
			sb.Append (message);

			switch(logType)
			{
			case LogType.Assert:
				Debug.Assert (true, StringBuilderCache.GetStringAndRelease (sb));
				break;
			case LogType.Exception:
			case LogType.Error:
				Debug.LogError (StringBuilderCache.GetStringAndRelease (sb));
				break;
			case LogType.Warning:
				Debug.LogWarning (StringBuilderCache.GetStringAndRelease (sb));
				break;
			default:
				Debug.Log (StringBuilderCache.GetStringAndRelease (sb));
				break;
			}
		}
	}
}
#endif