using UnityEngine;
public class Script_13_20 : MonoBehaviour  
{
	public CharacterController controller;
	void Start()
	{
		CollisionFlags flags = controller.Move (Vector3.forward);
		if (flags == CollisionFlags.None)
			print("没有发生碰撞");

		//因为可能出现身体的四周发生碰撞，并且脚与地面也发生碰撞的现象
		if ((flags & CollisionFlags.Sides) != 0)
			print("身体的四周发生碰撞");

		if (flags == CollisionFlags.Sides)
			print("只有身体的四周发生碰撞");

		if ((flags & CollisionFlags.Above) != 0)
			print("头部与上面发生碰撞");

		if (flags == CollisionFlags.Above)
			print("只有头部与上面发生碰撞");

		if ((flags & CollisionFlags.Below) != 0)
			print("脚与地面发生碰撞");

		if (flags == CollisionFlags.Below)
			print("只有脚与地面发生碰撞");
	}
}
