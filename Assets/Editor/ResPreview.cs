using UnityEngine;
public class ResPreview : MonoBehaviour
{

	///--------序列化信息面板-------- 
	[SerializeField]
    private string m_LoadPath = string.Empty;
	[SerializeField]
    private bool m_IsInitLoad = true;


	///--------序列化信息面板-------- 
	/// <summary>
	/// 资源是否已经完成加载
	/// </summary>
	public bool IsLoad { get; private set;}

	void Awake () 
	{
		IsLoad = false;
		if (m_IsInitLoad) {
			Load ();
		}
	}

	/// <summary>
	/// 加载资源
	/// </summary>
	public void Load()
	{
		GameObject prefab = Resources.Load<GameObject> (m_LoadPath);
		if (prefab) {
			GameObject go =	Instantiate<GameObject> (prefab);
			go.transform.SetParent (transform, false);
			go.name = prefab.name;
			#if UNITY_EDITOR
			foreach (Transform t in go.GetComponentsInChildren<Transform>()) {
				t.gameObject.hideFlags = HideFlags.NotEditable | HideFlags.DontSave;
			}
			#endif
		}


		IsLoad = true;
	}
}



