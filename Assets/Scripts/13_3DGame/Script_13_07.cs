using UnityEngine;

public class Script_13_07 : MonoBehaviour
{
	private Vector2 m_ScreenPotin= Vector3.zero;
	void Update()
	{ 
		if (Input.GetMouseButtonDown(0))  
		{  
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
			RaycastHit hit;  
			if (Physics.Raycast(ray, out hit))  
			{  
				//获取屏幕坐标
				m_ScreenPotin = Camera.main.WorldToScreenPoint (hit.point);
			}  
		}  
	}

	void OnGUI()
	{
		GUI.color = Color.red;
		GUI.Label (new Rect (m_ScreenPotin.x, Screen.height - m_ScreenPotin.y, 200, 40),string.Format("鼠标{0}",m_ScreenPotin));
	}
}
