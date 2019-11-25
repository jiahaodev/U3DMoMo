using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Video;


public class Script_10_08 : MonoBehaviour 
{

	public VideoPlayer videoPlayer;
	public Slider slider;

	void Start() 
	{
		slider.minValue = 0;
		slider.maxValue = (float)videoPlayer.clip.length;

		slider.onValueChanged.AddListener (delegate(float value) {
			videoPlayer.time = value;
		});
		videoPlayer.Play ();
	}

}
