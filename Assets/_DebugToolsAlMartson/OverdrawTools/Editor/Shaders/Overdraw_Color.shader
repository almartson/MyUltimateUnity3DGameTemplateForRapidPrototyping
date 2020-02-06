// Shader similar al de UNITY3D para mostrar el Overdraw, pero con color elegible.

Shader "Custom/Overdraw: Color + Texture"
{
  Properties 
  {
    _MainTex ("Base", 2D) = "white" {}
    _Color ("Main Color", Color) = (0.1, 0.04, 0.02, 0.15) //(0.15,0.0,0.0,0) //(0.15,0.0,0.0,0.15)
  }
 
  SubShader
  {
    Fog { Mode Off }
    ZWrite Off
    ZTest Always
    Blend One One // additive blending

    Pass
    {
      SetTexture[_MainTex] 
      {
        constantColor [_Color]
        combine constant, texture
      }
    }
  }
}
