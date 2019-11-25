using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_08_06  
{
	[MenuItem("Tools/Save")]
	static void Save()
	{
		EditorPrefs.SetInt ("MyInt", 100);
		EditorPrefs.SetFloat ("MyFloat", 200f);
		EditorPrefs.SetString ("MyString", "雨松MOMO");

		Debug.Log(EditorPrefs.GetInt ("MyInt", 0));
		Debug.Log(EditorPrefs.GetFloat ("MyFloat", 0f));
		Debug.Log(EditorPrefs.GetString ("MyString", "没有返回默认值"));


		//判断是否有某个key
		if (EditorPrefs.HasKey ("MyInt")) {
		
		}
		//删除某个Key
		EditorPrefs.DeleteKey ("MyInt");

		//删除所有Key
		EditorPrefs.DeleteAll ();
	}

}
