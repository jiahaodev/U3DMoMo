using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 
public class Script_05_06 :MonoBehaviour,IPointerClickHandler 
{
	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData)
	{
		Debug.LogFormat ("{0} is click", gameObject.name);
	}
	#endregion
	
}