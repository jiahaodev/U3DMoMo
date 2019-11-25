using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 
public class Script_05_07 :MonoBehaviour 
{
	public Button button1;
	public Button button2;

	public Text text;
	public Image image;

	void Awake()
	{
		button1.onClick.AddListener(delegate() {
			OnClick(button1.gameObject);
		});

		button2.onClick.AddListener(delegate() {
			OnClick(button2.gameObject);
		});
		UGUIEventListener.Get (text.gameObject).onClick = OnClick;
		UGUIEventListener.Get (image.gameObject).onClick = OnClick;
	}

	void OnClick(GameObject go)
	{
		if (go == button1.gameObject) {
			Debug.Log ("点击按钮1");
		} else if (go == button2.gameObject) {
			Debug.Log ("点击按钮2");
		}else if (go == text.gameObject) {
			Debug.Log ("点击文本框");
		}else if (go == image.gameObject) {
			Debug.Log ("点击图片");
		}
	}
	
}