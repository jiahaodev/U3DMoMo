Shader "Unlit/ZTestShader"
{
  Properties {
        //定义一个贴图
        _MainTex ("Base (RGB)", 2D) = "white" {} 
        _CutOff("Alpha cutoff", Range(0, 1)) =0.5
    }
    SubShader 
    {       
        Pass
        {
            alphatest greater[_CutOff]
            SetTexture [_MainTex] 
            {
                Combine texture * primary 
            }
        }
    } 
    FallBack "Diffuse"
}
