using UnityEngine;

public class Script_13_26 : MonoBehaviour 
{

    public SkinnedMeshRenderer[] combinMeshs;
    public SkinnedMeshRenderer skinnedMeshRenderer;

	private void Awake()
	{

        CombineInstance[] combines = new CombineInstance[combinMeshs.Length]; 

        for (int i = 0; i < combinMeshs.Length; i++)
        {
            combines[i].mesh = combinMeshs[i].sharedMesh;
            combines[i].transform = combinMeshs[i].transform.localToWorldMatrix;
        }
        var mesh = new Mesh();
        mesh.name = "combine";
        mesh.CombineMeshes(combines);
        skinnedMeshRenderer.sharedMesh = mesh;

	}
}
