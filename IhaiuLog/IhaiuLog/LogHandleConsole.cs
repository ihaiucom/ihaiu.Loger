using System;
using System.Text;

namespace ihaiu.logs
{
	public class LogHandleConsole : AbstractLogHandle
	{
		private ConsoleColor tmpColor;
		protected override void Print (LogType logType, object tag, object message, string stackTrack  = null)
		{
			StringBuilder sb = GetStringBuilder();
			sb.Append ("\t");
			sb.Append (logType);
			sb.Append ("\t");
			sb.Append (tag);
			sb.Append ("\t");
			sb.Append (message);

			tmpColor = Console.ForegroundColor;
			switch(logType)
			{
			case LogType.Exception:
			case LogType.Error:
			case LogType.Assert:
				Console.ForegroundColor = ConsoleColor.Red;
				break;
			case LogType.Warning:
				Console.ForegroundColor = ConsoleColor.Yellow;
				break;
			default:
				Console.ForegroundColor = ConsoleColor.Green;
				break;
			}

			Console.WriteLine (StringBuilderCache.GetStringAndRelease (sb));


			switch(logType)
			{
			case LogType.Exception:
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine (stackTrack);
				sb.Append ("\n\n");
				break;

			case LogType.Error:
			case LogType.Assert:
				if (Loger.StackTraceError)
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine (Environment.StackTrace);
					sb.Append ("\n\n");
				}
				break;
			default:
				if(Loger.StackTraceLog)
				{
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.WriteLine (Environment.StackTrace);
					sb.Append ("\n\n");
				}
				break;
			}

			Console.ForegroundColor = tmpColor;

		}


	}
}

