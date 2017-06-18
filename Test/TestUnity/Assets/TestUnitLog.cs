using UnityEngine;
using System.Collections;

public class TestUnitLog : MonoBehaviour
{

	public string 	tag 	= "Test";
	public bool 	isopen 	= true;

	void OnGUI()
	{

		float x = 10;
		float y = 10;
		float w = 100;
		float h = 50;
		float gapX = w + 50;
		float gapY = h + 10;
		if(GUI.Button(new Rect(x, y, w, h), "Log"))
		{
			Loger.Log("Hello Log");
		}

		y += gapY;
		if(GUI.Button(new Rect(x, y, w, h), "Error"))
		{
			Loger.LogError("This Is Error Log!!");
		}

		y += gapY;
		if(GUI.Button(new Rect(x, y, w, h), "Exception"))
		{
			Loger.LogException(new System.Exception("This Is Exception!!"));
		}

		y = 10;
		x += gapX;

		if(GUI.Button(new Rect(x, y, w, h), "Tag Log"))
		{
			Loger.Log(isopen, tag, "Hello Log");
		}

		y += gapY;
		if(GUI.Button(new Rect(x, y, w, h), "Tag Error"))
		{
			Loger.LogError(isopen, tag, "This Is Error Log!!");
		}

		y += gapY;
		if(GUI.Button(new Rect(x, y, w, h), "Tag Exception"))
		{
			Loger.LogTagException(tag, new System.Exception("This Is Exception!!"));
		}



		y = 10;
		x += gapX;

		if(GUI.Button(new Rect(x, y, w, h), "isopen=" + isopen))
		{
			isopen = !isopen;
		}




	}
}
