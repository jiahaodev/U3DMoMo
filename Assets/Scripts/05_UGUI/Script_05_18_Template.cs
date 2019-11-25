using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Template : MonoBehaviour {

    //绑定在某个脚本上，设置它不可被保存
	void Reset () 
    {
        foreach (var item in GetComponentsInChildren<RectTransform>(true))
        {
            //过滤掉自身
            if (item.gameObject != gameObject) { 
                item.gameObject.hideFlags = HideFlags.DontSave;
            }
        }
	}
}
