using System;
using ihaiu.logs;

public class Loger
{
	/** Log, Warning 是否打印栈 */
	public static bool		StackTraceLog			= false;
	/** Error, Assert 是否打印栈  */
	public static bool 		StackTraceError 		= false;

	private static bool 	defaultIsOpenNoTag 		= true;
	private static bool 	defaultIsOpenHasTag 	= true;
	private static string 	defaultTag 				= "Default";

	private static ILogHandle handle;

	public static ILogHandle Handle
	{
		get 
		{
			if (handle == null) 
			{
				#if UNITY
				handle = new LogHandleUnity();
				#else
				handle = new LogHandleConsole();
				#endif
			}
			return handle;
		}

		set 
		{
			handle = value;
		}
	}

	public static void SetHandle(ILogHandle handle)
	{
		Loger.Handle = handle;
	}

	// Log
	public static void Log					(object message)
	{
		Log (defaultIsOpenNoTag, defaultTag, message);
	}

	public static void LogFormat 			(string format, params object[] args)
	{
		LogFormat (defaultIsOpenNoTag, defaultTag, format, args);
	}



	// LogWarning
	public static void LogWarning 			(object message)
	{
		LogWarning (defaultIsOpenNoTag, defaultTag, message);
	}


	public static void LogWarningFormat 	(string format, params object[] args)
	{
		LogWarningFormat (defaultIsOpenNoTag, defaultTag, format, args);
	}




	// LogError
	public static void LogError 			(object message)
	{
		LogError (defaultIsOpenNoTag, defaultTag, message);
	}

	public static void LogErrorFormat 		(string format, params object[] args)
	{
		LogErrorFormat (defaultIsOpenNoTag, defaultTag, format, args);
	}




	// LogException
	public static void LogException 		(System.Exception exception)
	{
		LogTagException (defaultTag, exception);
	}



	// Assert
	public static void Assert 				(bool condition, string message)
	{
		AssertTag (defaultTag, condition, message);
	}




	#region tag
	//===========================================
	// tag
	//-------------------------------------------
	// Log
	public static void LogTag					(object tag, object message)
	{
		Log (defaultIsOpenHasTag, tag, message);
	}

	public static void LogTagFormat 			(object tag, string format, params object[] args)
	{
		LogFormat (defaultIsOpenHasTag, tag, format, args);
	}



	// LogWarning
	public static void LogTagWarning 			(object tag, object message)
	{
		LogWarning (defaultIsOpenHasTag, tag, message);
	}


	public static void LogTagWarningFormat 	(object tag, string format, params object[] args)
	{
		LogWarningFormat (defaultIsOpenHasTag, tag, format, args);
	}




	// LogError
	public static void LogTagError 			(object tag, object message)
	{
		LogError (defaultIsOpenHasTag, tag, message);
	}

	public static void LogTagErrorFormat 		(object tag, string format, params object[] args)
	{
		LogErrorFormat (defaultIsOpenHasTag, tag, format, args);
	}




	// LogException
	public static void LogTagException 		(object tag, System.Exception exception)
	{
		Handle.LogException (tag, exception);
	}



	// Assert
	public static void AssertTag 				(object tag, bool condition, string message)
	{
		Handle.Assert (tag, condition, message);
	}
	#endregion


	#region isopen tag
	//===========================================
	// isopen tag
	//-------------------------------------------


	// Log
	public static void Log					(bool isopen, object tag, object message)
	{
		Handle.Log (isopen, tag, message);
	}

	public static void LogFormat 			(bool isopen, object tag, string format, params object[] args)
	{
		Handle.LogFormat (isopen, tag, format, args);
	}



	// LogWarning
	public static void LogWarning 			(bool isopen, object tag, object message)
	{
		Handle.LogWarning (isopen, tag, message);
	}


	public static void LogWarningFormat 	(bool isopen, object tag, string format, params object[] args)
	{
		Handle.LogWarningFormat (isopen, tag, format, args);
	}




	// LogError
	public static void LogError 			(bool isopen, object tag, object message)
	{
		Handle.LogError (isopen, tag, message);
	}

	public static void LogErrorFormat 		(bool isopen, object tag, string format, params object[] args)
	{
		Handle.LogErrorFormat (isopen, tag, format, args);
	}
	#endregion





}
