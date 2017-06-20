# Loger
## Definition
C# Log 用来适配 Console.WriteLine 和 Unity Debug

## dll
用于Unity输出Log <a href="https://github.com/ihaiucom/ihaiu.Loger/blob/master/IhaiuLog/IhaiuLog/bin/Release/IhaiuLog_unity.dll" target="_bank">IhaiuLog_unity.dll</a> 

用于Console输出Log <a href="https://github.com/ihaiucom/ihaiu.Loger/blob/master/IhaiuLog/IhaiuLog/bin/Release/IhaiuLog.dll" target="_bank">IhaiuLog.dll</a>


## Test Unity
![](https://github.com/ihaiucom/ihaiu.Loger/blob/master/Test/doc/ihaiu.loger_unity.jpg?raw=true) 


编译 IhaiuLog_unity.dll 需要在Project Options -> Build -> Complier。 需要在Define Symbols添加UNITY
![](https://github.com/ihaiucom/ihaiu.Loger/blob/master/Test/doc/ihaiu.loger_unity_complier.jpg?raw=true) 



## Test Console
![](https://github.com/ihaiucom/ihaiu.Loger/blob/master/Test/doc/ihaiu.loger_console_1.png) 


![](https://github.com/ihaiucom/ihaiu.Loger/blob/master/Test/doc/ihaiu.loger_console_2.jpg) 



## Api

// Log

public static void Log					(object message);

public static void LogTag				(object tag, 	object message);

public static void Log					(bool 	isopen, object tag, 	object message);


<br>

// LogFormat

public static void LogFormat 			(string format, params object[] args);

public static void LogTagFormat 		(object tag, string format, params object[] args);

public static void LogFormat 			(bool isopen, object tag, string format, params object[] args);


// 其他的 Warning,Error Api也是一样的。


bool isopen 参数的目的是控制某个模块的log是否输出

object tag 参数的目的是为了方便查找某个模块的Log过滤


![](https://github.com/ihaiucom/ihaiu.Loger/blob/master/Test/doc/ihaiu.Loger.png?raw=true) 

你可以取实现自己的ILogHandle,比如把Log输出到文件。



<br>
<a href="http://blog.ihaiu.com/" target="_bank">我的博客 http://blog.ihaiu.com/</a>