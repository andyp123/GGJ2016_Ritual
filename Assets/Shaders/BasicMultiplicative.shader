// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:4,bdst:1,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:32719,y:32712,varname:node_3138,prsc:2|emission-4441-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31692,y:32760,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:0;n:type:ShaderForge.SFN_Tex2d,id:6538,x:31692,y:32927,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_6538,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:14e006b6d22f97e43a86d9145dc74983,ntxv:0,isnm:False;n:type:ShaderForge.SFN_OneMinus,id:5336,x:32169,y:32809,varname:node_5336,prsc:2|IN-8541-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:8541,x:31952,y:32871,ptovrint:False,ptlb:Invert,ptin:_Invert,varname:node_8541,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-6538-RGB,B-3886-OUT;n:type:ShaderForge.SFN_Multiply,id:3774,x:32332,y:32809,varname:node_3774,prsc:2|A-7241-RGB,B-5336-OUT;n:type:ShaderForge.SFN_Add,id:4441,x:32492,y:32809,varname:node_4441,prsc:2|A-3774-OUT,B-8541-OUT;n:type:ShaderForge.SFN_OneMinus,id:3886,x:31952,y:32991,varname:node_3886,prsc:2|IN-6538-RGB;proporder:7241-6538-8541;pass:END;sub:END;*/

Shader "Shader Forge/BasicMultiplicative" {
    Properties {
        _Color ("Color", Color) = (0,0,0,0)
        _MainTex ("MainTex", 2D) = "white" {}
        [MaterialToggle] _Invert ("Invert", Float ) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend DstColor Zero
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _Color;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform fixed _Invert;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 _Invert_var = lerp( _MainTex_var.rgb, (1.0 - _MainTex_var.rgb), _Invert );
                float3 emissive = ((_Color.rgb*(1.0 - _Invert_var))+_Invert_var);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
