using UnityEngine;
//using TMPro;

public class GameManager : MonoBehaviour
{

    #region Attributes

    // make game manager public static so can access this from other scripts
    public static GameManager _gm;

    #region Estados de Juego

    /// <summary>
    /// Estados del Juego Globales, por encima de todo.
    /// </summary>
    public enum _GAME_STATES { Menu, Playing, BeatLevel, Death, GameOver };

    /// <summary>
    /// Estados del Juego particulares: durante el ""gameState"": en un MENU.
    ///   Acá se colocan todos los TIPOS de MENU, con el fin de poder setear los valores de las Variables según las OPciones elegidas por el usuario.
    /// </summary>
    public enum _GAME_STATES_WHEN_IN_MENUS { InMainMenu, InSubMenuScreenResolutionOptions1, InSubMenuGameDificultyOptions1, InSubMenuLevel1, StartingTheGameInitialization , NotInAnyMenu  /* Implement it only if your Design Philosophy asks for it */ };


    /// <summary>
    /// Estados del Juego particulares: durante el ""gameState"": PLAYING.
    /// </summary>
    public enum _GAME_STATES_WHEN_PLAYING { InicializacionFinalVariables, PreparandoVariablesParaMiTurnoPartida, NotPlaying /*EsperandoPorAnimacionPeligroDeTerminarJuego,*/ /*EsperandoPorGUIRoundNumero, PorChutar, Chutando, CelebracionGol, CelebracionNoEsGol, AnimacionChutadorGol, AnimacionChutadorNoEsGol, AnimacionPorteroParadaExitosa, AnimacionPorteroFallo, AnimacionInicioSuddenDeath*/ /* NO SE USARÁN:  , AntesDePortear, Porteando */ };


    /// <summary>
    /// Estado Global del Juego.
    /// </summary>
    [Tooltip("Estado Global del Juego.")]
    public _GAME_STATES _mainAppGameState = _GAME_STATES.Menu;


    /// <summary>
    /// Estado Particular del Juego en MENUS.
    /// </summary>
    [Tooltip("Estado Particular del Juego en MENUS.")]
    public _GAME_STATES_WHEN_IN_MENUS _gameStateWhenInMenus = _GAME_STATES_WHEN_IN_MENUS.InMainMenu;

    /// <summary>
    /// Estado Particular del Juego en PLAYING.
    /// </summary>
    [Tooltip("Estado Particular del Juego en PLAYING.")]
    public _GAME_STATES_WHEN_PLAYING _gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaMiTurnoPartida;


    ///// <summary>
    ///// ESTADO: Esta la App pausada? O no?
    ///// </summary>
    //[Tooltip("ESTADO: Esta la App pausada? O no?")]
    //public bool _appEstaPausada = false;

    ///// <summary>
    ///// Si es TRUE: Se Activará INMEDIATAMENTE un CAMBIO DE ESTADO: Pausar/Despausar.
    ///// </summary>
    //[Tooltip("Si es TRUE: Se Activará INMEDIATAMENTE un CAMBIO DE ESTADO: Pausar/Despausar.")]
    //public bool _appCambiarDeEstadoTogglePauseODespause = false;

    #endregion Estados de Juego



    /// Buttons to restart the game to Level One
    [Tooltip("Buttons to restart the game to Level One")]
    public GameObject restartGameButtons;


    #region GUI elements

    // Ejemplo:::::::::
    ///// <summary>
    ///// GUI, TEXTO DE TextMeshPRO: Porcentaje de carga (load) al cargar el Juego, desde el MAIN MENU (para ser mostrado en la GUI).
    ///// </summary>
    //[Tooltip("GUI, TEXTO DE TextMeshPRO: Porcentaje de carga (load) al cargar el Juego, desde el MAIN MENU (para ser mostrado en la GUI).")]
    //public TextMeshProUGUI _miPorcentajeDeCargaGUIMenuLoadingSlideBar;


    #endregion GUI elements

    #endregion Attributes


    #region Methods

    // Awake is called before the Start
    void Awake()
    {
        // get a reference to the GameManager component for use by other scripts
        if (_gm == null)
        {
            _gm = this.gameObject.GetComponent<GameManager>();

        }//End if (_gm == null)


        /////Debug.Log("AWAKE() have been executed, in: GAME MANAGER.");

    }//End Awake Method


    // Start is called before the first frame update
    void Start()
    {

        /////Debug.Log("START() have been executed, in: GAME MANAGER.");

    }//End Start


    // Update is called once per frame
    void Update()
    {

        switch (this._mainAppGameState)
        {

            // Estado dentro del MAIN MENU (Menú Principal):
            //
            case _GAME_STATES.Menu:


                // Al estar JUGANDO casos:
                //
                switch (this._gameStateWhenInMenus)
                {

                    case _GAME_STATES_WHEN_IN_MENUS.InMainMenu:

                        // TODO:   Acá puedo SALVAR las OPCIONES elegidas por el Jugador (en caso de ser 'salvables'):
                        // Salvar:
                        //   1 - En variables acá en esta Clase (RAM).
                        //   2 - Luego en el Disco del Dispositivo (ROM), para Persistencia de la Data.
                        //   OJO: MUCHO CUIDADO de no salvar MAS DE UNA VEZ (OJO**** estamos en un UPDATE). Usar Banderas-Mutex...



                        // Capture Mouse Input Click:
                        //
                        //if (Input.GetMouseButtonDown(0))
                        //{
                        //    //Debug.Log("Pressed primary button.");

                        //}//End if (Input.GetMouseButtonDown(0))

                        break;



                    default:

                        Debug.LogError("ESTADO NO ESPERADO (para switch (this._gameStateWhenPlaying)), EN GameManager!");

                        break;

                }//End

                break;


            //*****************************************//
            //
            // Estado de JUGAR:
            //
            case _GAME_STATES.Playing:


                // Al estar JUGANDO casos:
                //
                switch (this._gameStateWhenPlaying)
                {

                    case _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables:

                        // Setear la variable de ESTADO al siguiente:
                        //
                        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaMiTurnoPartida;

                        break;


                    case _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaMiTurnoPartida:


                        //// Capture Mouse Input Click:
                        ////
                        //if (Input.GetMouseButtonDown(0))
                        //{
                        //    //Debug.Log("Pressed primary button.");

                        //}//End if (Input.GetMouseButtonDown(0))

                        break;


                    default:

                        Debug.LogError("ESTADO NO ESPERADO (para switch (this._gameStateWhenPlaying)), EN GameManager!");

                        break;

                }//End

                break;


            case _GAME_STATES.BeatLevel:


                break;


            case _GAME_STATES.Death:


                break;


            case _GAME_STATES.GameOver:


                break;


            default:

                Debug.LogError("ESTADO NO ESPERADO (para switch (this._mainAppGameState)), EN GameManager!");

                break;

        }//End switch (this._mainAppGameState)

    }//End Update


    #region **************************My Custom Methods*******************************


    //*****************MENUS***************INICIO***************//
    #region MENUS


    /// <summary>
    /// Setea las Variaables de Estado para poder Elegir una Opción que transporta a otra SCENE de Unity, a partir del Main Menu (Principal).
    /// </summary>
    public void ElegirOpcionDesdeOHaciaMenuPrincipal( int buildSettedScene )
    {

        //Debug.Log("ElegirOpcionDesdeOHaciaMenuPrincipal ha sido invocado");

        switch (buildSettedScene)
        {

            case 1:     // Irse a SCENE de valor (Build Settings) = '1' =>    Sub-Menu 1.

                // Setear la variable de ESTADO al MAIN MENU:  1:
                //
                this._mainAppGameState = _GAME_STATES.Menu;
                this._gameStateWhenInMenus = _GAME_STATES_WHEN_IN_MENUS.InMainMenu;
                this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.NotPlaying;

                break;


            case 2:     // Irse a SCENE de valor (Build Settings) = '2' =>    Level 1  (GAME START!).

                // Setear la variable de ESTADO al !JUGAR!:
                //
                this._mainAppGameState = _GAME_STATES.Playing;
                this._gameStateWhenInMenus = _GAME_STATES_WHEN_IN_MENUS.StartingTheGameInitialization;
                this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaMiTurnoPartida;

                break;

                //.......................agregar otros CASOS de MENU, acá!............................

            default:

                break;

        }//End witch

    }//End Method


    #endregion MENUS



    #endregion **************************My Custom Methods*******************************

    #endregion Methods
}
