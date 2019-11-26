/****************************************************
	文件：Script_04_17.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 2:02   	
	功能：4.4.11 工作线程 Job System
    核心：主线程 和 工作线程，需要用Native来传递数据
*****************************************************/
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

public class Script_04_17 : MonoBehaviour {

    public Transform[] cubes;

    void Update()
	{
        //按下鼠标左键后
        if(Input.GetMouseButtonDown(0))
        {
            //随机设置坐标
            NativeArray<Vector3> position = new NativeArray<Vector3>(cubes.Length, Allocator.Persistent);
            for (int i = 0; i < position.Length; i++){
                position[i] = Vector3.one * i;
            }
            //设置Transform
            TransformAccessArray transformArray = new TransformAccessArray(cubes);
            //启动工作线程
            MyJob job = new MyJob(){position = position};
            JobHandle jobHandle = job.Schedule(transformArray);
            //等待工作线程结束
            jobHandle.Complete();
            Debug.Log("工作线程结束");
            //结束
            transformArray.Dispose();
            position.Dispose();
        }
	}


    struct MyJob : IJobParallelForTransform
    {
        //只读属性
        [ReadOnly]public NativeArray<Vector3> position;

        public void Execute(int index, TransformAccess transform)
        {
            //工作线程中设置坐标
            transform.position = position[index];
        }
    }
}
