using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_07_01  {

	[InitializeOnLoadMethod]
	static void InitializeOnLoadMethod()
	{
		//监听Prefab保存事件
		PrefabUtility.prefabInstanceUpdated = delegate(GameObject instance) {
			Debug.LogFormat("Prefab {0} 被保存",AssetDatabase.GetAssetPath(PrefabUtility.GetPrefabParent(instance)));
		};
	}
}
