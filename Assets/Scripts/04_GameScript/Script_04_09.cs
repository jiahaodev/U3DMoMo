/****************************************************
	文件：Script_04_09.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 0:23   	
	功能：兼容源生绘制 与 自定义渲染
    核心：源生 ：EditorGUILayout.PropertyField
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Script_04_09 : MonoBehaviour 
{
	[SerializeField]
	private int id;
	[SerializeField]
	private GameObject[] targets;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Script_04_09))]
public class ScriptInsector_Script_04_09 : Editor
{
	public override void OnInspectorGUI ()
	{
		//更新最新数据
		serializedObject.Update ();
		//获取数据信息
		SerializedProperty property = serializedObject.FindProperty ("id");
		//赋值数据
		property.intValue = EditorGUILayout.IntField ("主键", property.intValue);
		//以默认样式绘制数组数据
		EditorGUILayout.PropertyField(serializedObject.FindProperty ("targets"), true);
		//全部保存数据
		serializedObject.ApplyModifiedProperties ();
	}
}
#endif