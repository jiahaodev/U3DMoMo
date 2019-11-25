using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Script_13_22 : MonoBehaviour  
{
	CharacterController controller;
	void Awake()
	{
		controller = GetComponent<CharacterController> ();

		TriggerListener.triggerEventEnter.AddListener (delegate(Collider collider) {
			Debug.LogFormat("触发到{0}",collider.name);
		});

	}

	private Vector3 m_MoveToPosition;
	void Update()
	{
		
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				//面朝选择点
				m_MoveToPosition = new Vector3(hit.point.x,controller.transform.position.y,hit.point.z);
				controller.transform.LookAt(m_MoveToPosition);
			}
		}
		//只要目标点小于0.1米就移动
		if (Vector3.Distance (m_MoveToPosition, controller.transform.position) > 0.1f) {

			Vector3 back = controller.transform.position;
			CollisionFlags flags = controller.Move (controller.transform.rotation * Vector3.forward * Time.deltaTime * 2f);
			if ((flags & CollisionFlags.Sides) != 0){
				//发生碰撞停下来，并且还原坐标
				m_MoveToPosition = controller.transform.position = back;
			}
		}
	}




	void OnControllerColliderHit(ControllerColliderHit hit) 
	{
		//获取控制器，
		CollisionFlags flags = 	hit.controller.collisionFlags;
		//因为可能出现身体的四周发生碰撞，并且脚与地面也发生碰撞的现象
		if ((flags & CollisionFlags.Sides) != 0)
			Debug.LogFormat("身体的四周与{0}发生碰撞",hit.collider.name);

		if (flags == CollisionFlags.Sides)
			Debug.LogFormat("只有身体的四周与{0}发生碰撞",hit.collider.name);

		if ((flags & CollisionFlags.Above) != 0)
			Debug.LogFormat("头部与上面的{0}发生碰撞",hit.collider.name);

		if (flags == CollisionFlags.Above)
			Debug.LogFormat("只有头部与上面的{0}发生碰撞",hit.collider.name);

		if ((flags & CollisionFlags.Below) != 0)
			Debug.LogFormat("脚与地面的{0}发生碰撞",hit.collider.name);

		if (flags == CollisionFlags.Below)
			Debug.LogFormat("只有脚与地面的{0}发生碰撞",hit.collider.name);
	}
}
