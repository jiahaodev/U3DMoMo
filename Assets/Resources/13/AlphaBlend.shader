Shader "Unlit/ZTestShader"
{
  Properties {
        //定义一个贴图
        _MainTex ("Base (RGB)", 2D) = "white" {} 
    }
    SubShader 
    {       

        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha
            SetTexture [_MainTex] 
            {
                Combine texture * primary  //正面赋予贴图
            }
        }
    } 
    FallBack "Diffuse"
}
