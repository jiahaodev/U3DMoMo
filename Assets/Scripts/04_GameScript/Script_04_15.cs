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
//		WaitTimeManager.CancelWait (ref coroutine);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
