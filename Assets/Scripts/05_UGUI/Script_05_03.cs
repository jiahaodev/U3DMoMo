using UnityEngine;
using UnityEngine.UI;
 
public class Script_05_03 : MonoBehaviour
{
	public Toggle []toogles;

	void Start()
	{
		foreach (var toogle in toogles) {

			toogle.onValueChanged.AddListener (delegate(bool selected) {
				Debug.LogFormat("toogle = {0} selected = {1}",toogle.name,selected);
			});
		}
	}
}