using UnityEngine;
using UnityEngine.UI;
 
public class Script_05_02 : MonoBehaviour
{
	public Button button;

	void Start()
	{
		button.onClick.AddListener(delegate() {
			Debug.Log("click");
		});
	}
}