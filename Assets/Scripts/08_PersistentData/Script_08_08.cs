using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_08_08 : MonoBehaviour
{
	void Start()
	{
		Debug.Log (Resources.Load<TextAsset> ("MyText").text);
	}
}
