using UnityEngine;

public class UINumber : MonoBehaviour {

    //精灵原始资源
    [SerializeField]
    private Sprite[] numberRes;
    //输入区域
    [TextArea(2,4)][SerializeField]
    private string text;

	void Start () 
    {
        Refresh();
	}
	

    void Refresh()
    {
        for (int i = 0; i < text.Length; i++)
        {
            int a;
            if (int.TryParse(text[i].ToString(), out a))
            {
                //如果缓存中没有则创建新的
                SpriteRenderer spriteRenderer = new GameObject().AddComponent<SpriteRenderer>();
                spriteRenderer.sprite = numberRes[a];
                spriteRenderer.gameObject.SetActive(true);
                spriteRenderer.gameObject.name = a.ToString();
                spriteRenderer.transform.SetParent(transform, false);
                spriteRenderer.transform.localPosition = new Vector3(i * 0.2f, 0f, 0f);
            }
        }
    }
}
