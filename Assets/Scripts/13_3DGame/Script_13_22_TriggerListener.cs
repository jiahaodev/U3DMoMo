using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : UnityEvent<Collider>{}

public class TriggerListener : MonoBehaviour {

	public static TriggerEvent triggerEventEnter = new TriggerEvent ();

	void OnTriggerEnter(Collider collider)  
	{  
		//抛出事件
		triggerEventEnter.Invoke (collider);
	} 
}
