using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Camera))]
public class ModelCamera : MonoBehaviour {

	//ui
	public RectTransform uiArea;
	//模型
	public Transform model;

	void Update () 
	{
		model.transform.position = uiArea.transform.position;
		//自适应分辨率
		float designWidth = 1136;//开发时分辨率宽
		float designHeight = 640;//开发时分辨率高
		float designScale  =   designWidth/designHeight;
		float scaleRate  =   (float)Screen.width/(float)Screen.height;
		float scaleFactor = scaleRate / designScale;
		if(scaleRate<designScale)
		{
			model.localScale = Vector3.one * scaleFactor;
		}else{
			model.localScale = Vector3.one;
		}
	}
}
