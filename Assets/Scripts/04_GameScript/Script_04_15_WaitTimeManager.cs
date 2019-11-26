/****************************************************
	文件：Script_04_15_WaitTimeManager.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 1:46   	
	功能：4.4.9 定时器 定义
    核心：（1）单例脚本
          （2）内部使用一个MonoBehaviour管理协程
          （3）通过内部协程组件，实现定时任务
    注意：WaitTime（） 返回的是每次启动的协程对象，是不同的
    usage:
    	//开启定时器
		Coroutine coroutine = WaitTimeManager.WaitTime(5f,delegate {
			Debug.LogFormat("等待5秒后回调");
		});

		//等待过程中取消它
        //WaitTimeManager.CancelWait (ref coroutine);
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaitTimeManager  
{
	private static TaskBehaviour m_Task;
	static WaitTimeManager()
	{
		GameObject go = new GameObject("#WaitTimeManager#");
		GameObject.DontDestroyOnLoad(go);
		m_Task = go.AddComponent<TaskBehaviour> ();
	}

	//等待
	static public Coroutine WaitTime(float time,UnityAction callback)
	{
        //注意
		return m_Task.StartCoroutine (Coroutine(time,callback));
	}
	//取消等待
	static public void CancelWait(ref Coroutine coroutine)
	{
		if (coroutine != null) {
			m_Task.StopCoroutine (coroutine);
			coroutine = null;
		}
	}

	static IEnumerator Coroutine(float time,UnityAction callback){
		yield return new WaitForSeconds (time);
		if (callback != null) {
			callback ();
		}
	}
	//内部类
	class TaskBehaviour : MonoBehaviour{}
}
