/****************************************************
	�ļ���Script_04_04.cs
	���ߣ�JiahaoWu
	����: jiahaodev@163.ccom
	���ڣ�2019/11/26 23:51   	
	���ܣ�4.2.3�ű�������Э������
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
