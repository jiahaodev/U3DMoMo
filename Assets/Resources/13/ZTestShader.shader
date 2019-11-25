Shader "Unlit/ZTestShader"
{
   Properties {
        _NotVisibleColor ("NotVisibleColor (RGB)", Color) = (0.3,0.3,0.3,1)
        _MainTex ("Base (RGB)", 2D) = "white" {}
    }
    SubShader {
        Tags { "Queue" = "Geometry+500" "RenderType"="Opaque" }
        LOD 200
 
        Pass {
            ZTest Greater
            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha
            SetTexture [_MainTex] { ConstantColor [_NotVisibleColor] combine constant * texture }
        }
 
        Pass {
            ZTest LEqual
            SetTexture [_MainTex] { combine texture } 
        }
 
    } 
    FallBack "Diffuse"
}
