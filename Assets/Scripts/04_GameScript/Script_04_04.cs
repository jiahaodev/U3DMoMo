/****************************************************
	文件：Script_04_04.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/26 23:51   	
	功能：4.2.3脚本更新与协程任务
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_04 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CreateCube());
    }

    IEnumerator CreateCube()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position =
                Vector3.one * i;
            yield return new WaitForSeconds(1f);
        }
    }
}
