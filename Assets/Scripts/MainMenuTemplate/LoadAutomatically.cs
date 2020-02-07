using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class allows us to load a scene automatically, in a certain programmed moment.
/// </summary>
public class LoadAutomatically : MonoBehaviour
{

    /// <summary>
    /// The Level to Load.
    /// </summary>
    [Tooltip("The Level to Load.")]
    public int _myLevel = 1;
   


    public void Start()
    {
        // Note:
        // 1- It is important to execute this in an Start() Method, because a 'DoNotDestroy()' Method is being executed inside an 'Awake()' of another Script.
        //
        // Load Next Scene:
        //
        LoadScene();

    }//End Method


    #region Custom Methods
       
    /// <summary>
    /// Loads the scene set in The Inspector.
    /// </summary>
    public void LoadScene()
    {
        // DEPRECATED CODE:     // Application.LoadLevel(this._myLevel);

        // Setear Variables de ESTADO DEL JUEGO y del MENU:
        //
        GameManager._gm.ElegirOpcionDesdeOHaciaMenuPrincipal(this._myLevel);
        //
        //Application.LoadLevel(level);  // Deprecated code
        //
        SceneManager.LoadScene(this._myLevel);
        
    }//End Method

    #endregion Custom Methods

}
