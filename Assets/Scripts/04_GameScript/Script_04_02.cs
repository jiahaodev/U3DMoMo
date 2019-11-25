/************************************************************
    文件: ScriptsInfoRecoder.cs
	作者: JiahaoWu
    邮箱: jiahaodev@163.com
    日期: 2019/11/25 22:59:34
	功能: 4.2.1脚本绑定事件
    仅仅在编辑模式下，可以通过Reset()方法来实现。
    触发：（1）脚本挂在某个游戏对象上 （2）右键菜单Reset
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_02 : MonoBehaviour
{

#if UNITY_EDITOR
    void Reset()
    {
        Debug.LogFormat("GameObject:{0}绑定脚本Script_04_02", gameObject.name);
    }

#endif

}
