/****************************************************
	文件：Script_04_16.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/11/27 2:00   	
	功能：4.4.10 CustomYieldInstruction  自定义挂起指令
    核心： keepWaiting属性 的  true /false
*****************************************************/
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Script_04_16 : MonoBehaviour {

    IEnumerator Start () 
    {
        //十秒后结束
        yield return new CustomWait(10f,1f,delegate() {
            Debug.LogFormat("每过一秒回调一次 ：{0}",Time.time);

        });
        Debug.Log("十秒结束");
	}


    //派生：自定义挂起指令
	public class CustomWait : CustomYieldInstruction
    {
        public override bool keepWaiting
        {
            get
            {
                //此方法返回false表示协程结束
                if(Time.time - m_StartTime >= m_Time){
                    return false;
                }else if(Time.time - m_LastTime >= m_Interval){
                    //更新上一次间隔时间
                    m_LastTime = Time.time;
                    m_IntervalCallback();
                }
                return true;
            }
        }

        private UnityAction m_IntervalCallback;
        private float m_StartTime;
        private float m_LastTime;
        private float m_Interval;
        private float m_Time;

        public CustomWait(float time, float interval, UnityAction callback)
        {
            //记录开始时间
            m_StartTime = Time.time;
            //记录上一次间隔时间
            m_LastTime = Time.time;
            //记录间隔调用时间
            m_Interval = interval;
            //记录总时间
            m_Time = time;
            //间隔回调
            m_IntervalCallback =  callback;
        }
    }
}
