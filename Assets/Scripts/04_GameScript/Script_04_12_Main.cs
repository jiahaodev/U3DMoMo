/****************************************************
	�ļ���Script_04_12_Main.cs
	���ߣ�JiahaoWu
	����: jiahaodev@163.ccom
	���ڣ�2019/11/27 1:25   	
	���ܣ�����ScriptObject�Ķ�ȡ
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_12_Main : MonoBehaviour {

	void Start () {
		Script_04_12 script = Resources.Load<Script_04_12> ("04/New Script_04_12");
		Debug.LogFormat ("name : {0} id : {1}", script.m_PlayerInfo [0].name, script.m_PlayerInfo [0].id);
	}
}
