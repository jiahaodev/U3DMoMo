using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_06_01 : MonoBehaviour {

	public Camera camera;

	void Update () 
	{
		float designWidth = 1136f;//开发时分辨率宽
		float designHeight = 640f;//开发时分辨率高
		float designOrthographicSize=3.2f;//开发时正交摄像机Size
		float designScale  =  designWidth/designHeight;
		float scaleRate  =  (float)Screen.width/(float)Screen.height;
		if(scaleRate<designScale)
		{
			float scale = scaleRate / designScale;
			camera.orthographicSize = 3.2f / scale;
		}else{
			camera.orthographicSize = 3.2f;
		}
	}

	void OnGUI()
	{
		GUILayout.Label (string.Format ("<size=60><color=red>{0} X {1} </color></size>", Screen.width, Screen.height));
	}
}
