using System.Collections;
using UnityEngine;
using UnityEditor;

public class Script_08_11 : MonoBehaviour 
{
	[MenuItem("Assets/Open PersistentDataPath")]
	static void Open()
	{
		EditorUtility.RevealInFinder (Application.persistentDataPath);
	}
}
