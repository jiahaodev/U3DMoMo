using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_13_13 : MonoBehaviour {

	void Awake()
	{
		//同时打开多场景
		SceneManager.LoadScene ("Scene 1",LoadSceneMode.Additive);
		SceneManager.LoadScene ("Scene 2",LoadSceneMode.Additive);
	}
	void Start()
	{
		//获取场景对象
		Scene scene1 = SceneManager.GetSceneByName ("Scene 1");
		Scene scene2 = SceneManager.GetSceneByName ("Scene 2");

		GameObject g1 = new GameObject ("g1");
		GameObject g2 = new GameObject ("g2");

		//将游戏对象放入对应场景中
		SceneManager.MoveGameObjectToScene (g1, scene1);
		SceneManager.MoveGameObjectToScene (g2, scene2);
	
		//判断游戏对象属于那个场景
		Debug.LogFormat ("{0} 属于Scene 1",g1.scene.name);
		Debug.LogFormat ("{0} 属于Scene 2",g1.scene.name);
	}
}
