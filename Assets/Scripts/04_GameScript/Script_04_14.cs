using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_14 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//调用单例脚本方法
		Global.instance.DoSomeThings ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
