Shader "Unlit/VertexandFragmentShader"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		Pass
		{
            //标记CG程序块起始
			CGPROGRAM
            //执行顶点着色方法
			#pragma vertex vert
            //执行片段着色方法
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			v2f vert (appdata_base v)
			{
                //输出几何图形顶点以及UV信息
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
                //输入自定义着色信息
				fixed4 col = tex2D(_MainTex, i.uv);
				return col;
			}
            //标记CG程序块结束
			ENDCG
		}
	}
}
