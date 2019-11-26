/****************************************************
	�ļ���Script_04_14_Global.cs
	���ߣ�JiahaoWu
	����: jiahaodev@163.ccom
	���ڣ�2019/11/27 1:32   	
	���ܣ�4.4.8 �����ű�
    ���ģ���1����̬������ 
          ��2�������ڲ�GameObject���󣬲�����DontDestroyOnLoad��������
    �Ż��㣺����������Ҫ��ʽ���ص�GameObeject��������
            Global.instance.DoSomeThings ();
            ���ü���ͳһ���ʵ�
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour 
{

	public static Global instance;

	static Global()
	{
		GameObject go = new GameObject("#Globa#");
		DontDestroyOnLoad(go);
		instance = go.AddComponent<Global>();
	}

	public void DoSomeThings()
	{
		Debug.Log("DoSomeThings");
	}

	void Start () 
	{
		Debug.Log("Global Start");
	}
}
