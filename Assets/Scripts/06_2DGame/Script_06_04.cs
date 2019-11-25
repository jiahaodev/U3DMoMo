using UnityEngine;

public class Script_06_04 : MonoBehaviour 
{
	public Animator animator;
	public SpriteRenderer heroRenderer;
	private State m_State = State.Idle;

	void Awake()
	{
        Idle();
	}

	void Update()
	{

        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal"); 

        //纵向移动
        if (y > 0)
        {
            Run(Direction.Up, Vector3.up);
        }else if (y < 0)
        {
            Run(Direction.Down, Vector3.down);
        }
        //横向移动
        if (x > 0)
        {
            Run(Direction.Right, Vector3.right);
        }else if (x < 0)
        {
            Run(Direction.Left, Vector3.left);
        }

        //奔跑状态中，松手后回归待机状态
        if (m_State == State.Run)
        {
            if (Mathf.Approximately(x, 0f) && Mathf.Approximately(y, 0f))
            {
                Idle();
            }
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
