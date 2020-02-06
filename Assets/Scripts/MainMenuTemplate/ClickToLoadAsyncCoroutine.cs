using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class ClickToLoadAsyncCoroutine : MonoBehaviour
{

    /// <summary>
    /// My loading (Slider - Progress) Bar.
    /// </summary>
    [Tooltip("Loading (Slider - Progress) Bar")]
    public Slider _myLoadingBar;

    /// <summary>
    /// (Canvas of) Image with Slider and al UI stuff that will appear: while Loading.
    /// </summary>
    [Tooltip("(Canvas of) Image with Slider and al UI stuff that will appear: while Loading.")]
    public Canvas _myCanvasComponentOfLoadingImage;

    /// <summary>
    /// Async operation object, which will allow for 'asking questions', such as: 'Are you done?'.
    /// </summary>
    private AsyncOperation _myAsyncOperation;


    #region Custom Methods

    /// <summary>
    /// This Method Loads Level AND LOADING SLIDER - BAR.
    /// </summary>
    /// <param name="sceneNumber"></param>
    public void ClickAsyncLoadScene(int sceneNumber)
    {
        ///_myLoadingImage.SetActive(true); // This is SubOptimal.
        // Set the image as: Active.
        //
        if (this._myCanvasComponentOfLoadingImage != null)
        {
            // Make VISIBLE the "loading" slider UI element:
            //
            this._myCanvasComponentOfLoadingImage.enabled = true;

        }//End if
        //
        // Setear Variables para INICIAR JUEGO, desde MENU PRINICPAL:
        //
        GameManager.gm.ElegirOpcionDesdeOHaciaMenuPrincipal(sceneNumber);
        //
        // This Method Loads Level AND LOADING SLIDER - BAR:
        //
        StartCoroutine(LoadLevelWithBar(sceneNumber));

    }//End Method


    IEnumerator LoadLevelWithBar (int level)
    {
        //Deprecated code: _myAsyncOperation = Application.LoadLevelAsync(level);
        //
        this._myAsyncOperation = SceneManager.LoadSceneAsync(level);

        while (!_myAsyncOperation.isDone)
        {
            _myLoadingBar.value = _myAsyncOperation.progress;
            yield return null;
        }
    }//End Method

    #endregion Custom Methods

}
