/****************************************************
	文件：Script_04_08.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 0:12   	
	功能：4.4.2 私有序列化数据
    核心：OnInspectorGUI ()。 在加载属性面板时，获取序列化的数据，并填充显示
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Script_04_08 : MonoBehaviour 
{
	[SerializeField]
	private int id;
	[SerializeField]
	private string name;
	[SerializeField]
	private GameObject prefab;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Script_04_08))]
public class ScriptInsector_Script_04_08:Editor
{
	public override void OnInspectorGUI ()
	{
		//更新最新数据
		serializedObject.Update ();
		//获取数据信息
		SerializedProperty property = serializedObject.FindProperty ("id");
		//赋值数据
		property.intValue = EditorGUILayout.IntField ("主键", property.intValue);

		property = serializedObject.FindProperty ("name");
		property.stringValue = EditorGUILayout.TextField ("姓名", property.stringValue);

		property = serializedObject.FindProperty ("prefab");
		property.objectReferenceValue = EditorGUILayout.ObjectField ("游戏对象", property.objectReferenceValue,typeof(GameObject),true);

		//全部保存数据
		serializedObject.ApplyModifiedProperties ();
	}
}
#endif