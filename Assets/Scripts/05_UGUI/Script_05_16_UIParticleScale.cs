using UnityEngine;
using System.Collections.Generic;

public class UIParticleScale : MonoBehaviour 
{
	struct ScaleData
	{
		public Transform transform;
		public Vector3 beginScale;
	}

	const float DESIGN_WIDTH = 1136f;//开发时分辨率宽
	const float DESIGN_HEIGHT = 640f;//开发时分辨率高

	private Dictionary<Transform,ScaleData> m_ScaleData = new Dictionary<Transform, ScaleData> ();

	void Start () 
    {	
		Refresh ();
	}

    void Refresh()
	{
		float designScale = DESIGN_WIDTH / DESIGN_HEIGHT;
		float scaleRate = (float)Screen.width/(float)Screen.height;

		foreach (ParticleSystem p in transform.GetComponentsInChildren<ParticleSystem>(true)) {
			if (!m_ScaleData.ContainsKey (p.transform)) {
				m_ScaleData [p.transform] = new ScaleData (){ transform = p.transform, beginScale = p.transform.localScale };
			}
		}
		foreach(var item in m_ScaleData)
		{
			if(scaleRate<designScale)
			{
				float scaleFactor = scaleRate / designScale;
				item.Value.transform.localScale = item.Value.beginScale * scaleFactor;
			}else{
				item.Value.transform.localScale  = item.Value.beginScale;
			}
		}
	}

	/// <summary>
	/// 子节点发生变化重新刷深度
	/// </summary>
	void OnTransformChildrenChanged()
	{
		Refresh ();
	}
#if UNITY_EDITOR
    //编辑模式下修改分辨率在后Update中刷新
    private void Update()
    {
        Refresh();
    }
#endif
	
}
