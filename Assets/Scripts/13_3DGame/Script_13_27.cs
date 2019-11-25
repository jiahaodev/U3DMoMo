using System;
using UnityEngine;
using UnityEngine.UI;

public class Script_13_27 : MonoBehaviour 
{

    public Texture2D texture;

	private void Awake()
	{
        if(texture.format ==  TextureFormat.DXT5 ||
           texture.format == TextureFormat.ETC2_RGBA8||
           texture.format == TextureFormat.ASTC_RGBA_4x4)
        {
            byte[] data = new byte[1024 * 1024];
            int blcokBytes = 16;
            //从小图的（0,0）位置开始拷贝至大图的(0,0)并且保持宽高是256X256
            CombineBlocks(texture.GetRawTextureData(), 0, 0, data, 0, 0, 256, 256, 4, blcokBytes, 1024);
            var combinedTex = new Texture2D(1024, 1024, texture.format, false);
            combinedTex.LoadRawTextureData(data);
            combinedTex.Apply();
            GetComponent<RawImage>().texture = combinedTex;
        }
	}

    void CombineBlocks(byte[] src, int srcx, int srcy, byte[] dst, int dstx, int dsty, int width, int height, int block, int bytes,int maxWidth)
    {
        var srcbx = srcx / block;
        var srcby = srcy / block;

        var dstbx = dstx / block;
        var dstby = dsty / block;

        for (int i = 0; i < height / block; i++)
        {
            int dstindex = (dstbx + (dstby + i) * (maxWidth / block)) * bytes;
            int srcindex = (srcbx + (srcby + i) * (width / block)) * bytes;
            Buffer.BlockCopy(src, srcindex, dst, dstindex, width / block * bytes);
        }
    }
}
