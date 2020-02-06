using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class ClickToLoadAsync : MonoBehaviour
{

    public Slider _myLoadingBar;
    public GameObject _myLoadingImage;


    private AsyncOperation _myAsyncOperation;


    public void ClickAsync(int level)
    {
        _myLoadingImage.SetActive(true);
        StartCoroutine(LoadLevelWithBar(level));
    }


    IEnumerator LoadLevelWithBar (int level)
    {
        // DEPRECATED CODE:  // this._myAsyncOperation = Application.LoadLevelAsync(level);

        //Application.LoadLevel(level);  // Deprecated code
        //
        SceneManager.LoadScene(level);

        while (!_myAsyncOperation.isDone)
        {
            _myLoadingBar.value = _myAsyncOperation.progress;
            yield return null;
        }
    }
}
