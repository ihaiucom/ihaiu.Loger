using System;

namespace TestConsole
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Log, Warning 是否打印栈
			Loger.StackTraceLog 	= false;
			// Error, Assert 是否打印栈
			Loger.StackTraceError 	= false;


			Loger.Log("Hello Log 1");
			Loger.Log("Hello Log 2");
			Loger.LogWarning("Ha Ha Ha");
			Loger.LogError("Hello Error 1");

			// tag
			bool 	isopen 		= true;
			string 	tag 		= "Socket";

			Loger.Log(isopen, tag, "This Is Log, Socket Connect!!");
			Loger.Log(isopen, tag, "This Is Log, Socket Close!!");

			// 关闭这段
			isopen = false;
			Loger.Log(isopen, tag, "proto 0x01 Login");
			Loger.Log(isopen, tag, "proto 0x02 Logout");

			// 打印 调用栈
			Loger.StackTraceError 	= true;
			Loger.LogError("Hello Error 2");
		}
	}
}
