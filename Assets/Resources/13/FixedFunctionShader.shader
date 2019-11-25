Shader "Unlit/FixedFunctionShader"
{
	Properties
	{
        //主纹理
		_MainTex ("Texture", 2D) = "white" {}
    }

	SubShader
	{
       Pass { 
            //设置主纹理  
            SetTexture [_MainTex] {  
                combine texture  
            }  
        } 
	}
}
