using UnityEngine;
using UnityEngine.UI;
 
public class Script_05_04 : MonoBehaviour
{
	public Slider slider;

	void Start()
	{
		//设置取值范围的最大最小值
		slider.minValue = 0;
		slider.maxValue = 100;


		slider.onValueChanged.AddListener (delegate(float value) {
			Debug.LogFormat("value = {0}",value);
		});
	}
}