/****************************************************
	�ļ���Script_04_12.cs
	���ߣ�JiahaoWu
	����: jiahaodev@163.ccom
	���ڣ�2019/11/27 1:25   	
	���ܣ�����������
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Script_04_12 : ScriptableObject
{
	[SerializeField]
	public List<PlayerInfo> m_PlayerInfo;

	[System.Serializable]
	public class PlayerInfo
	{
		public int id;
		public string name;
	}
}
