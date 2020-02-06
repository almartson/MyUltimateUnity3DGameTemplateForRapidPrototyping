using System;
using UnityEngine;

/// <summary> opcion 2, escrita por el amigo de la UNITY3D Forum: prayshouse
/// En: https://forum.unity.com/threads/how-to-get-fillrate-or-average-overdraw-from-unity-profiler.494882/#post-3265454
/// </summary>

public class OverdrawMonitor : MonoBehaviour
{
//    private static OverdrawMonitor instance;
//    public static OverdrawMonitor Instance
//    {
//        get
//        {
//            if (instance == null)
//            {
//                instance = GameObject.FindObjectOfType<OverdrawMonitor>();
//                if (instance == null)
//                {
//                    var go = new GameObject("OverdrawMonitor");
//                    instance = go.AddComponent<OverdrawMonitor>();
//                }
//            }
//            return instance;
//        }
//    }
//
//    /// <summary>
//    /// Agregar a este apuntador la CAMARA PRINCIPAL.
//    /// </summary>
//    [Tooltip("Agregar a este apuntador la CAMARA PRINCIPAL.")]
//    public Camera _miCamaraPrincipal;
//
//    /// <summary>
//    /// Camara de OVERDAW, secundaria.
//    /// </summary>
//    private Camera _miCamaraOverdraw;
//	
//    /// <summary>
//    /// (Solo será usado si no se define un Shader valido abajo) Nombre de: Shader a usar de REEMPLAZO en la camara, para ver el OVERDRAW
//    /// </summary>
//    [Tooltip("(Solo será usado si no se define un Shader valido abajo) Nombre de: Shader a usar de REEMPLAZO en la camara, para ver el OVERDRAW")]
//    public string replacementShaderString = "Custom/Overdraw: Color + Texture"; // "Custom/Overdraw: Texture"; // "Custom/Overdraw Objectos especificos"; // "Debug/OverdrawInt";
//
//    /// <summary>
//    /// Shader a usar de REEMPLAZO en la camara, para ver el OVERDRAW
//    /// </summary>
//    [Tooltip("Shader a usar de REEMPLAZO en la camara, para ver el OVERDRAW")]
//    public Shader replacementShader;
//
//
//    public void Awake()
//    {
//        if (Application.isPlaying) DontDestroyOnLoad(gameObject);
//        //
//		//Original: 
//        //
//        replacementShader = Shader.Find( replacementShaderString );
// 
//        _miCamaraOverdraw = GetComponent<Camera>();
//        if (_miCamaraOverdraw == null) _miCamaraOverdraw = gameObject.AddComponent<Camera>();
//
//        // Main Camera initialization:
//        //
//        this._miCamaraPrincipal = Camera.main;
//
//        //camera.CopyFrom(Camera.main);
//        //
//        _miCamaraOverdraw.CopyFrom( this._miCamaraPrincipal );
//		//
//        //Original: 
//		_miCamaraOverdraw.SetReplacementShader(replacementShader, null);
//		//
//		// Mio, prueba:
//		//
//		//_miCamaraOverdraw.SetReplacementShader(replacementShader, "RenderType");
//		//
//		//Ejemplo con TAG:	camera.SetReplacementShader (EffectShader, "RenderType");
//    }
// 
// 
//    // Use this for initialization
//    void Start()
//    {
//        _miCamaraOverdraw.enabled = false;
//    }
// 
////    // Update is called once per frame
////    void Update()
////    {
//// 
////    }
// 
//    public void LateUpdate()
//    {
//        ///Original:    Camera main = Camera.main;
//        //
//        //Camera main = Camera.main;
//
//        _miCamaraOverdraw.CopyFrom( _miCamaraPrincipal );
//        _miCamaraOverdraw.clearFlags = CameraClearFlags.SolidColor;
//        _miCamaraOverdraw.backgroundColor = Color.black;		
//		//
//        //Original: 
//		_miCamaraOverdraw.SetReplacementShader(replacementShader, null);
//		//
//		// Mio, prueba:
//		//
//		//_miCamaraOverdraw.SetReplacementShader(replacementShader, "RenderType");
//		//
//		//Ejemplo con TAG:	camera.SetReplacementShader (EffectShader, "RenderType");
// 
//        transform.position = _miCamaraPrincipal.transform.position;
//        transform.rotation = _miCamaraPrincipal.transform.rotation;
//    }
}
