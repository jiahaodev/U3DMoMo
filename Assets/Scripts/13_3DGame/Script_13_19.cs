using UnityEngine;
using UnityEditor;
using UnityEngine.EventSystems;
public class Script_13_19 : MonoBehaviour  
{
	//模型
	public Transform model;
	//3dtextMesh
	public TextMesh textMesh;
	//移动目的地
	private Vector3 m_MoveToPosition=Vector3.zero;

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			 


			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				//面朝选择点
				m_MoveToPosition = new Vector3(hit.point.x,model.position.y,hit.point.z);
				model.LookAt(m_MoveToPosition);

				textMesh.text = string.Format ("点击位置{0}", hit.point);
				textMesh.transform.position = hit.point;
			}
		}
		if (model.position != m_MoveToPosition) {
			//步长
			float step = 5f * Time.deltaTime;
			model.position = Vector3.MoveTowards (model.position, m_MoveToPosition, step);
		}
	}
}
