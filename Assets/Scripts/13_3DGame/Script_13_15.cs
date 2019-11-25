using UnityEngine;
using UnityEditor;

public class Script_13_15  {

	[MenuItem("Tool/BakeMultipleScenes")]
	static void BakeMultipleScenes()
	{
		//指定烘焙场景
		Lightmapping.BakeMultipleScenes (new string[] {
			"Assets/Scene.unity",
			"Assets/Scene 1.unity",	
			"Assets/Scene 2.unity",	
		});
	}
}
