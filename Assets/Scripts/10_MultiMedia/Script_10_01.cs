using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Script_10_01 : MonoBehaviour 
{
	public AudioClip clip1;
	public AudioClip clip2;

	public AudioSource source;


	void OnGUI()
	{

		if (GUILayout.Button ("<size=50>播放音频1</size>")) {
			PlayAudioClip (clip1,delegate(AudioClip clip) {
				Debug.LogFormat("音频：{0}播放结束",clip.name);
			});
			
		}
		if (GUILayout.Button ("<size=50>播放音频2</size>")) {
			PlayAudioClip (clip2,delegate(AudioClip clip) {
				Debug.LogFormat("音频：{0}播放结束",clip.name);
			});
		}
	}

	private Coroutine m_Coroutine = null;
	void PlayAudioClip(AudioClip clip,UnityAction<AudioClip> callback)
	{
		StopAudioClip ();
		source.clip = clip;
		source.Play ();
		m_Coroutine = StartCoroutine (AduioClipCallback (clip, callback));
	}

	void StopAudioClip()
	{
		if (m_Coroutine != null) {
			StopCoroutine (m_Coroutine);
			m_Coroutine = null;
		}
		source.Stop ();
	}

	private IEnumerator AduioClipCallback(AudioClip clip,UnityAction<AudioClip> callback)
	{  
		yield return new WaitForSeconds (clip.length);  
		callback (clip);  
	}
}
