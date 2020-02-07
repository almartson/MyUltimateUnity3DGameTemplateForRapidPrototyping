using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadAdditive : MonoBehaviour
{

    public void LoadAddOnClick(int level)
    {

        // Deprecated code: //Application.LoadLevelAdditive(level);

        // Setear Variables de ESTADO DEL JUEGO y del MENU:
        //
        GameManager._gm.ElegirOpcionDesdeOHaciaMenuPrincipal(level);
        //
        //Application.LoadLevel(level);  // Deprecated code
        //
        SceneManager.LoadScene(level);

    }//End Method

}
