/****************************************************
	文件：Script_04_10.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 0:27   	
	功能：4.4.4 检测Inspector面板元素修改事件
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Script_04_10 : MonoBehaviour 
{
	[SerializeField]
	private GameObject[] targets;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Script_04_10))]
public class ScriptInsector_Script_04_10 : Editor
{
	public override void OnInspectorGUI ()
	{
		//更新最新数据
		serializedObject.Update ();
		//标记检查 【核心1】
		EditorGUI.BeginChangeCheck ();
		EditorGUILayout.PropertyField(serializedObject.FindProperty ("targets"), true);
        //标记检查发生变化 【核心2】
        if (EditorGUI.EndChangeCheck ()) {
			Debug.Log ("元素发生变化");
		}
		//判断面板元素是否任意发生改变
		if (GUI.changed) {
		
		}
		//全部保存数据
		serializedObject.ApplyModifiedProperties ();

	}
}
#endif