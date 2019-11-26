/****************************************************
	文件：Script_04_13_RangeIntAttribute.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 1:27   	
	功能：4.4.7 脚本的Attributes特性 【了解即可】
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
public sealed class RangeIntAttribute: PropertyAttribute
{
	public readonly int min;

	public readonly int max;

	public RangeIntAttribute (int min, int max)
	{
		this.min = min;
		this.max = max;
	}
}

#if UNITY_EDITOR
[CustomPropertyDrawer( typeof( RangeIntAttribute ) )]
public sealed class RangeIntDrawer : PropertyDrawer
{
	public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
	{
		return 100; //设置面板的高度
	}
	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
	{
		RangeIntAttribute attribute = this.attribute as  RangeIntAttribute;
		property.intValue = Mathf.Clamp (property.intValue, attribute.min, attribute.max);
		EditorGUI.HelpBox(new Rect (position.x, position.y, position.width, 30),
			string.Format("范围{0}~{1}",attribute.min, attribute.max),MessageType.Info);

		EditorGUI.PropertyField( new Rect (position.x, position.y +35, position.width, 20), property, label );
	}
}
#endif