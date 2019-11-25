using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Video;


public class Script_10_04 : MonoBehaviour 
{

	public VideoPlayer videoPlayer;
	public Button button;

	void Start() 
	{
		button.onClick.AddListener (delegate() {
			videoPlayer.Stop();
		});
	}

}
