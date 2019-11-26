/****************************************************
	文件：Script_04_14_Global.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 1:32   	
	功能：4.4.8 单例脚本
    核心：（1）静态构造器 
          （2）创建内部GameObject对象，并设置DontDestroyOnLoad，添加组件
    优化点：这个组件不需要显式挂载到GameObeject，而是像
            Global.instance.DoSomeThings ();
            调用即可统一访问到
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
