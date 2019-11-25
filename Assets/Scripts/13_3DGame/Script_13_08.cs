using UnityEngine;

public class Script_13_08 : MonoBehaviour
{
	//英雄头顶
	public Transform heroTransform;
	//血条
	public RectTransform hpTransform;
	//UI摄像机
	public Camera UICamera;
	//Canvas
	public RectTransform canvasTransform;

	void Update()
	{ 
		//先将3D坐标转成成屏幕坐标	
		Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(Camera.main, heroTransform.position);
		//在将屏幕坐标转换UI坐标
		Vector2 localPoint;
		if(RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasTransform,screenPoint,UICamera, out localPoint)){
			hpTransform.anchoredPosition = localPoint;
		}
	}
}
