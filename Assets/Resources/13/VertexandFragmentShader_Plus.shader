Shader "Unlit/VertexandFragmentShader_Plus"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
        //设置光照类型为前向渲染
        Tags {"LightMode"="ForwardBase"}

		Pass
		{
            //标记CG程序块起始
			CGPROGRAM
            //执行顶点着色方法
			#pragma vertex vert
            //执行片段着色方法
			#pragma fragment frag
			#include "UnityCG.cginc"
            #include "UnityLightingCommon.cginc"

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
                fixed4 diff : COLOR0; // 漫反射光颜色
                fixed3 ambient : COLOR1;//环境光颜色
                 
            };

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			v2f vert (appdata_base v)
			{
                //输出几何图形顶点以及UV信息
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
                //计算漫反射环境光颜色
                half3 worldNormal = UnityObjectToWorldNormal(v.normal);
                half nl = max(0, dot(worldNormal, _WorldSpaceLightPos0.xyz));
                o.diff = nl * _LightColor0;
                o.ambient = ShadeSH9(half4(worldNormal,1));
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
                //输入自定义着色信息
				fixed4 col = tex2D(_MainTex, i.uv);
                //添加漫反射以及环境光
                fixed3 lighting = i.diff + i.ambient;
                col.rgb *= lighting;
				return col;
			}
            //标记CG程序块结束
			ENDCG
		}
	}
}
