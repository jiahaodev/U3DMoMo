/****************************************************
	文件：Script_04_12_Main.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 1:25   	
	功能：测试ScriptObject的读取
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
