using UnityEngine;


public class DontDestroy : MonoBehaviour
{

    /// <summary>
    /// Awake this instance.
    /// Use this for initialization
    /// </summary>
    void Awake ()
    {

        DontDestroyOnLoad(gameObject);

    }
}
