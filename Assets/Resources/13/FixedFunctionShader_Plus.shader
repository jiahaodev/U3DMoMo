Shader "Unlit/FixedFunctionShader_Plus"
{
	Properties
	{
        //主纹理
		_MainTex ("Texture", 2D) = "white" {}
        //颜色
        _Color ("Main Color", Color) = (1,1,1,0)
    }

	SubShader
	{
       Pass { 
            Lighting On  
            Material {
               Diffuse [_Color]//接收漫反射光
               Ambient [_Color]//接收环境光
             }

            //设置主纹理  
            SetTexture [_MainTex] {  
                combine previous * texture  
            }  
        } 
	}
}
