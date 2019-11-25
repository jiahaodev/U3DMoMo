using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System.IO;
using UnityEngine.UI;
public class Script_10_03 : MonoBehaviour 
{

	public AudioSource source;

	public Slider slider;

	void Start() 
	{

		slider.minValue = 0;
		slider.maxValue = source.clip.length;


		slider.onValueChanged.AddListener (delegate(float value) {
			source.Stop();
			source.time = value;
			source.Play ();
		});

		source.Play ();

	}

}
