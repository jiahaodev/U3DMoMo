using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_06_06 : MonoBehaviour 
{
	public Animator animator;
	public SpriteRenderer heroRenderer;

	private Direction m_Direction = Direction.None;
	private State m_State = State.Idle;

	void Update()
	{
		//处理方向键
		if (Input.GetKey (KeyCode.W)) {
			Run (Direction.Up,Vector3.up);
		}else if (Input.GetKey (KeyCode.S)) {
			Run (Direction.Down,Vector3.down);
		}else if (Input.GetKey (KeyCode.A)) {
			Run (Direction.Left,Vector3.left);
		}else if (Input.GetKey (KeyCode.D)) {
			Run (Direction.Right,Vector3.right);
		}else if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)){
			Idle ();
		} 
		//处理跳跃
		if (Input.GetKey (KeyCode.Space)) {
			Jump ();
		}else if (Input.GetKeyUp (KeyCode.Space)) {
			Idle ();
		}

	}

	void Idle()
	{
		SetState(State.Idle);
	}

	void Run(Direction dir,Vector3 postion)
	{
		SetState(State.Run);

		heroRenderer.flipX = (dir == Direction.Left);
		heroRenderer.transform.position += (postion * 0.1f);
	}

	void Jump()
	{
		SetState(State.Jump);
	}

	void SetState(State newState)
	{
		m_State = newState;
		animator.SetBool ("run", m_State == State.Run);
		animator.SetBool ("jump", m_State == State.Jump);
	}


	enum State
	{
		Idle=1,
		Run,
		Jump,
	}

	enum Direction
	{
		None=1,
		Up,
		Down,
		Left,
		Right
	}
}
