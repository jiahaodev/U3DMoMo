using UnityEngine;

public class Script_09_01 :MonoBehaviour
{
	//烘培贴图1
	public Texture2D lightmap1;
	//烘培贴图2
	public Texture2D lightmap2;

	void OnGUI()
	{
		if(GUILayout.Button("<size=50>lightmap1</size>"))
		{
			LightmapData data = new LightmapData();
			data.lightmapColor = lightmap1;
			LightmapSettings.lightmaps = new LightmapData[1]{data};
		}

		if(GUILayout.Button("<size=50>lightmap2</size>"))
		{
			LightmapData data = new LightmapData();
			data.lightmapColor = lightmap2;
			LightmapSettings.lightmaps = new LightmapData[1]{data};
		}
	}
}
