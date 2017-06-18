using System;
using System.Text;

namespace ihaiu.logs
{
	public abstract class AbstractLogHandle : ILogHandle
	{
		public void Log					(bool isopen, object tag, object message)
		{
			if (!isopen)
				return;

			Print (LogType.Log, tag, message);
		}

		public void LogFormat 			(bool isopen, object tag, string format, params object[] args)
		{
			if (!isopen)
				return;

			Print (LogType.Log, tag, string.Format(format, args));
		}

		public void LogWarning 			(bool isopen, object tag, object message)
		{
			if (!isopen)
				return;

			Print (LogType.Warning, tag, message);
		}
		public void LogWarningFormat 	(bool isopen, object tag, string format, params object[] args)
		{
			if (!isopen)
				return;

			Print (LogType.Warning, tag, string.Format(format, args));
		}

		public void LogError 			(bool isopen, object tag, object message)
		{
			if (!isopen)
				return;

			Print (LogType.Error, tag, message);
		}

		public void LogErrorFormat 		(bool isopen, object tag, string format, params object[] args)
		{
			if (!isopen)
				return;

			Print (LogType.Error, tag, string.Format(format, args));

		}

		virtual public void LogException 		(object tag, System.Exception exception)
		{
			Print (LogType.Exception, tag, exception.Message, exception.StackTrace);
		}

		virtual public void Assert 				(object tag, bool condition, string message)
		{
			if(condition)
				Print (LogType.Assert, tag, message);
		}

		virtual protected void Print(LogType logType, object tag, object message, string stackTrack = null)
		{
			
		}

		protected StringBuilder GetStringBuilder()
		{
			StringBuilder sb = StringBuilderCache.Acquire();
			DateTime time = DateTime.Now;        
			sb.Append(time.Hour);
			sb.Append(":");
			sb.Append(time.Minute);
			sb.Append(":");
			sb.Append(time.Second);
			sb.Append(".");
			sb.Append(time.Millisecond);
			return sb;
		}



	}
}


