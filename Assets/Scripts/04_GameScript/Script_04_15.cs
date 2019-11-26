/****************************************************
	文件：Script_04_15.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 1:42   	
	功能：4.4.9 定时器 测试
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_15 : MonoBehaviour {

	// Use this for initialization
	void Start () {


		//开启定时器
		Coroutine coroutine = WaitTimeManager.WaitTime(5f,delegate {
			Debug.LogFormat("等待5秒后回调");
		});

        //等待过程中取消它
        //WaitTimeManager.CancelWait(ref coroutine);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
