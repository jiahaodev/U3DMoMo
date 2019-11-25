using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.U2D;

public class Script_05_12 : MonoBehaviour
{
	public Image image;

	private SpriteAtlas m_SpriteAtlas = null;

	void Start()
	{
		m_SpriteAtlas = Resources.Load<SpriteAtlas> ("New Sprite Atlas");
	}

	void OnGUI()
	{
		if (GUILayout.Button ("<size=80>更换sprite</size>")) {
			image.sprite = m_SpriteAtlas.GetSprite ("unity");
		}
	}
}

