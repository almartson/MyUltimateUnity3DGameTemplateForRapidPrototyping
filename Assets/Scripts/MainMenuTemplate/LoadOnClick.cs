using UnityEngine;

/// <summary>
/// This class allows us to load a scene when clicked.
/// </summary>
public class LoadOnClick : MonoBehaviour
{

    /// <summary>
    /// (Canvas Component of): Image with Slider and al UI stuff that will appear: while Loading.
    /// </summary>
    [Tooltip("(Canvas Component of): Image with Slider and al UI stuff that will appear: while Loading.")]
    public /*GameObject*/ Canvas _myCanvasComponentOfLoadingImage;


    public void LoadScene(int level)
    {
        // Set the image as: Active.
        //
        if ( this._myCanvasComponentOfLoadingImage != null )
        {
            this._myCanvasComponentOfLoadingImage.enabled = true;

        }//End if
        //
        Application.LoadLevel(level);
    }
}
