using UnityEngine;
using UnityEngine.EventSystems;
public class Script_13_18 : MonoBehaviour  
{
	void Start()
	{
		Click3D.click3DEvent.AddListener (delegate(GameObject gameObject,PointerEventData arg1) {
			Debug.LogFormat("点选3D模型: {0}",gameObject.name);
		});
	}
}
