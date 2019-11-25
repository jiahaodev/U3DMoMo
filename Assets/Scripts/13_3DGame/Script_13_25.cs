using System.Collections.Generic;
using UnityEngine;

public class Script_13_25 : MonoBehaviour {


    private GameObjectPool m_Pool = null;
    private Stack<GameObject> m_Objects = null;

	private void Awake()
	{
        m_Pool = new GameObjectPool("Cube");
        m_Objects = new Stack<GameObject>();
	}

	private void OnGUI()
	{
        if(GUILayout.Button("<size=50>Get</size>")){
            GameObject go= m_Pool.GetObject("Cube");
            go.transform.SetParent(transform, false);
            m_Objects.Push(go);
        }
        if (GUILayout.Button("<size=50>Release</size>"))
        {
            if (m_Objects.Count > 0)
            {
                m_Pool.ReleaseObject(m_Objects.Pop());
            }
        }
	}
}
