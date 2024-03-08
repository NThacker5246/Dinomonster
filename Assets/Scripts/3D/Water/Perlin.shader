Shader "Custom/Perlin" {
	Properties {
		_MainTex ("Main Texture", 2D) = "white" {}
		_PerlinTex ("Perlin Noise Texture", 2D) = "white" {}
		_Scale ("Scale", Range(0, 1)) = 0.1
	}
 
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
 
		CGPROGRAM
		#pragma surface surf Lambert
 
		sampler2D _MainTex;
		sampler2D _PerlinTex;
		float _Scale;
 
		struct Input {
			float2 uv_MainTex;
		};
 
		void surf (Input IN, inout SurfaceOutput o) {
			float2 perlinUV = IN.uv_MainTex * _Scale;
			float4 perlinColor = tex2D(_PerlinTex, perlinUV);
			float4 mainColor = tex2D(_MainTex, IN.uv_MainTex);
 
			o.Albedo = mainColor.rgb * perlinColor.r;
			o.Alpha = mainColor.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
