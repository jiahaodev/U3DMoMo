/****************************************************
	文件：Script_04_12.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 1:25   	
	功能：定义数据类
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
