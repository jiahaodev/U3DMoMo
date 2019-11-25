using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Video;


public class Script_10_07 : MonoBehaviour 
{

	public VideoPlayer videoPlayer;
	public InputField inputField;
	public Button button;

	void Start() 
	{
		button.onClick.AddListener (delegate() {
			videoPlayer.source = VideoSource.Url;
			videoPlayer.url = string.Format("file://{0}",inputField.text);
			videoPlayer.Play();
		});
	}

}
