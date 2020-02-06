// Shader similar al de UNITY3D ORIGINAL para mostrar el Overdraw, con color constante.

Shader "Custom/Overdraw Objectos especificos"
{
  Properties
  {
    _MainColor ("Color (RGB) Alpha (A)" , Color ) = (0.1, 0.04, 0.02, 0.15) // (0.15,0.0,0.0,0.15) // (0, 0, 0, 0)
  }
    
  SubShader
  {
  
    Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
    
    //Tags are important. Queue tells Unity to render this object after we render all the solid geometry.
    //Otherwise they would write over us.

    ZWrite Off
    Blend SrcAlpha OneMinusSrcAlpha 

    //Alpha Blending (_MainColor.rgb * _MainColor.a + _CurrentPixelColor.rgb * (1 - _MainColor.a) = Final Color on Screen.

    Pass
    {
      Color [_MainColor]
    }
  }
}
