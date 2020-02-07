using UnityEngine;
using System;
//using System.Reflection.Emit;
//using UnityEngine.UI;
using TMPro;

using UnityEngine.Profiling;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShowSliderValueTMP : MonoBehaviour
{

    /// <summary>
    /// GUI, TEXTO DE TextMeshPRO: Porcentaje de carga (load) al cargar el Juego, desde el MAIN MENU (para ser mostrado en la GUI).
    /// </summary>
    [Tooltip("GUI, TEXTO DE TextMeshPRO: Porcentaje de carga (load) al cargar el Juego, desde el MAIN MENU (para ser mostrado en la GUI).")]
    public TextMeshProUGUI _myLbl;


    void Awake()
    {

        // Get the TextMeshProUGUI Label
        //
        this._myLbl = GetComponent<TextMeshProUGUI>();

    }//End Method
    

    public void UpdateLabel(float value)
    {
        //Old Unoptimized code:     TextMeshProUGUI _myLbl = GetComponent<TextMeshProUGUI>();

        //Old Unoptimized code:     TextMeshProUGUI _myLbl = GetComponent<TextMeshProUGUI>();
        //if (_myLbl != null)
        //    _myLbl.text = Mathf.RoundToInt(value * 100) + "%";

        if (this._myLbl != null)
        {

            Profiler.BeginSample("Test of: gstring.Block()");

            using (gstring.Block())  // My trial for no generating Garbage Allocations: Pointer to Strings (Author: VEXE): Garbage Collector Free Strings!
            {

                //  Repositories, GStrings:
                //->
                //https://github.com/vexe/gstring
                //https://github.com/almartson/gstring  (Note: This is my own Fork, a clone XD)
                //
                //  The Main discussion in an Unity Forum:
                //->
                //https://forum.unity.com/threads/gstring-gc-free-string-for-unity.338588/
                //
                this._myLbl.text = gstring.Concat( Mathf.RoundToInt(value * 100), "%" ).Intern();

            }//End using (gstring.Block())

            Profiler.EndSample();

        }//End if            
    }//ENd Method

}
