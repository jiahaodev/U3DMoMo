using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_13_12 : MonoBehaviour {

	void OnGUI()
	{
		if (GUILayout.Button ("<size=50>加载多场景</size>")) {
			SceneManager.LoadSceneAsync ("Scene 1", LoadSceneMode.Additive);
		}

		if (GUILayout.Button ("<size=50>卸载多场景</size>")) {
			SceneManager.UnloadSceneAsync ("Scene 1");
		}
	}
}
