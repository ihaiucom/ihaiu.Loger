using System;


namespace ihaiu.logs
{
	public interface ILogHandle
	{
//		void Log				(object message);
//		void LogFormat 			(string format, params object[] args);
//
//		void LogWarning 		(object message);
//		void LogWarningFormat 	(string format, params object[] args);
//
//
//
//		void LogError 			(object message);
//		void LogErrorFormat 	(string format, params object[] args);
//
//		void LogException 		(System.Exception exception);
//		void Assert 			(bool condition, string message);
//
//
//
//		//===========================================
//		// tag
//		//-------------------------------------------
//		void Log				(object tag, object message);
//		void LogFormat 			(object tag, string format, params object[] args);
//
//		void LogWarning 		(object tag, object message);
//		void LogWarningFormat 	(object tag, string format, params object[] args);
//
//
//		void LogError 			(object tag, object message);
//		void LogErrorFormat 	(object tag, string format, params object[] args);
//
//
//		void LogException 		(object tag, System.Exception exception);
//		void Assert 			(object tag, bool condition, string message);


		//===========================================
		// isopen tag
		//-------------------------------------------
		void Log				(bool isopen, object tag, object message);
		void LogFormat 			(bool isopen, object tag, string format, params object[] args);

		void LogWarning 		(bool isopen, object tag, object message);
		void LogWarningFormat 	(bool isopen, object tag, string format, params object[] args);

		void LogError 			(bool isopen, object tag, object message);
		void LogErrorFormat 	(bool isopen, object tag, string format, params object[] args);

		void LogException 		(object tag, System.Exception exception);
		void Assert 			(object tag, bool condition, string message);
	}
}