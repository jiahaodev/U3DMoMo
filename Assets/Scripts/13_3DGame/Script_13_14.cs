using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_13_14 : MonoBehaviour {

	void Awake()
	{
		//同时打开多场景
		SceneManager.LoadScene ("Scene 1",LoadSceneMode.Additive);
		SceneManager.LoadScene ("Scene 2",LoadSceneMode.Additive);


		SceneManager.activeSceneChanged += delegate(Scene arg0, Scene arg1) {
			Debug.LogFormat("场景激活: {0} {1}",arg0.name,arg1.name);	
		};

		SceneManager.sceneLoaded += delegate(Scene arg0, LoadSceneMode arg1) {
			Debug.LogFormat("场景加载: {0} 加载模式: {1}",arg0.name,arg1.ToString());	
		};

		SceneManager.sceneUnloaded += delegate(Scene arg0) {
			Debug.LogFormat("场景卸载: {0} ",arg0.name);	
		};
	}

	void Start()
	{
		//设置场景激活状态
		Scene scene2 = SceneManager.GetSceneByName ("Scene 2");
		SceneManager.SetActiveScene (scene2);
		//如果不指定场景，对象将创建在当前激活的场景中
		new GameObject ("MyNewGameObject");
	}
}
