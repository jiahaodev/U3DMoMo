using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Camera))]
public class ModelCamera : MonoBehaviour {

	//RawImage
	public RawImage rawImage;

	void Start () 
	{
		//避免RenderTexture显示不清楚，所以乘以显示区域的1.5倍。
		float rate = 1.5f;
		int width = (int)(rawImage.rectTransform.sizeDelta.x * rate);
		int height = (int)(rawImage.rectTransform.sizeDelta.y * rate);
		RenderTexture renderTexture = RenderTexture.GetTemporary (width, height, 16, RenderTextureFormat.ARGB32);
		GetComponent<Camera> ().targetTexture = renderTexture;
		rawImage.texture = renderTexture;
	}

}
