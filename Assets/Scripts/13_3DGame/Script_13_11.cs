using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_13_11 : MonoBehaviour
{

	void Start()
	{
		//禁止切场景卸载初始化的游戏对象
		GameObject[]InitGameObjects	= GameObject.FindObjectsOfType<GameObject>();
		foreach(GameObject go in InitGameObjects){
			if (go.transform.parent == null)
			{
				GameObject.DontDestroyOnLoad(go.transform.root);
			}
		}

		//加载场景
		SceneLoadManager.LoadScene ("New Scene", delegate(float progress) {
			Debug.LogFormat("加载进度:{0}",progress);
		}, delegate() {
			Debug.Log("加载结束");
		});
	}
}
