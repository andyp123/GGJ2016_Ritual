// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9361,x:33182,y:32431,varname:node_9361,prsc:2|custl-107-OUT,olwid-2904-OUT,olcol-2515-RGB;n:type:ShaderForge.SFN_Tex2d,id:3565,x:31940,y:32295,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_3565,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:15b2ef77dc6171c46a32105acc42d49d,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:8863,x:31940,y:32479,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_8863,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:8347,x:32318,y:32764,ptovrint:False,ptlb:Ramp,ptin:_Ramp,varname:node_8347,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3aa06bc02f6b8ef44a54a77fe335701b,ntxv:0,isnm:False|UVIN-6361-OUT;n:type:ShaderForge.SFN_Multiply,id:2904,x:32877,y:32896,varname:node_2904,prsc:2|A-5492-OUT,B-310-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:7504,x:32877,y:33237,ptovrint:False,ptlb:OutlineWidthFixed,ptin:_OutlineWidthFixed,varname:node_7504,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False;n:type:ShaderForge.SFN_ValueProperty,id:5492,x:32877,y:32844,ptovrint:False,ptlb:OutlineWidth,ptin:_OutlineWidth,varname:node_5492,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.005;n:type:ShaderForge.SFN_Color,id:2515,x:32877,y:33039,ptovrint:False,ptlb:OutlineColor,ptin:_OutlineColor,varname:node_2515,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Distance,id:310,x:32709,y:32896,varname:node_310,prsc:2|A-6508-XYZ,B-2578-XYZ;n:type:ShaderForge.SFN_ViewPosition,id:2578,x:32525,y:33015,varname:node_2578,prsc:2;n:type:ShaderForge.SFN_FragmentPosition,id:6508,x:32525,y:32896,varname:node_6508,prsc:2;n:type:ShaderForge.SFN_AmbientLight,id:8974,x:32164,y:32343,varname:node_8974,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6147,x:32369,y:32343,varname:node_6147,prsc:2|A-8974-RGB,B-3865-OUT,C-484-OUT;n:type:ShaderForge.SFN_Add,id:107,x:32877,y:32564,varname:node_107,prsc:2|A-6147-OUT,B-6451-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:875,x:32318,y:33044,varname:node_875,prsc:2;n:type:ShaderForge.SFN_LightVector,id:5804,x:31805,y:32764,varname:node_5804,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:3327,x:31805,y:32893,prsc:2,pt:False;n:type:ShaderForge.SFN_Append,id:6361,x:32146,y:32764,varname:node_6361,prsc:2|A-6697-OUT,B-8599-OUT;n:type:ShaderForge.SFN_Dot,id:6697,x:31975,y:32764,varname:node_6697,prsc:2,dt:0|A-5804-OUT,B-3327-OUT;n:type:ShaderForge.SFN_Vector1,id:8599,x:31975,y:32912,varname:node_8599,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:6451,x:32556,y:32668,varname:node_6451,prsc:2|A-3865-OUT,B-8347-RGB,C-9939-RGB,D-875-OUT;n:type:ShaderForge.SFN_LightColor,id:9939,x:32318,y:32922,varname:node_9939,prsc:2;n:type:ShaderForge.SFN_Slider,id:484,x:32164,y:32262,ptovrint:False,ptlb:Ambient,ptin:_Ambient,varname:node_484,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:3865,x:32164,y:32479,varname:node_3865,prsc:2|A-3565-RGB,B-8863-RGB,C-9431-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9431,x:31940,y:32644,ptovrint:False,ptlb:Boost,ptin:_Boost,varname:node_9431,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;proporder:5492-2515-3565-8863-8347-484-9431;pass:END;sub:END;*/

Shader "Shader Forge/Toon" {
    Properties {
        _OutlineWidth ("OutlineWidth", Float ) = 0.005
        _OutlineColor ("OutlineColor", Color) = (0,0,0,1)
        _MainTex ("MainTex", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)
        _Ramp ("Ramp", 2D) = "white" {}
        _Ambient ("Ambient", Range(0, 1)) = 1
        _Boost ("Boost", Float ) = 1
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float _OutlineWidth;
            uniform float4 _OutlineColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*(_OutlineWidth*distance(mul(_Object2World, v.vertex).rgb,_WorldSpaceCameraPos)),1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_OutlineColor.rgb,0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _Color;
            uniform sampler2D _Ramp; uniform float4 _Ramp_ST;
            uniform float _Ambient;
            uniform float _Boost;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 node_3865 = (_MainTex_var.rgb*_Color.rgb*_Boost);
                float2 node_6361 = float2(dot(lightDirection,i.normalDir),0.0);
                float4 _Ramp_var = tex2D(_Ramp,TRANSFORM_TEX(node_6361, _Ramp));
                float3 finalColor = ((UNITY_LIGHTMODEL_AMBIENT.rgb*node_3865*_Ambient)+(node_3865*_Ramp_var.rgb*_LightColor0.rgb*attenuation));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _Color;
            uniform sampler2D _Ramp; uniform float4 _Ramp_ST;
            uniform float _Ambient;
            uniform float _Boost;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 node_3865 = (_MainTex_var.rgb*_Color.rgb*_Boost);
                float2 node_6361 = float2(dot(lightDirection,i.normalDir),0.0);
                float4 _Ramp_var = tex2D(_Ramp,TRANSFORM_TEX(node_6361, _Ramp));
                float3 finalColor = ((UNITY_LIGHTMODEL_AMBIENT.rgb*node_3865*_Ambient)+(node_3865*_Ramp_var.rgb*_LightColor0.rgb*attenuation));
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
