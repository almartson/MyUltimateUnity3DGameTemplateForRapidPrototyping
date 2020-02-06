using UnityEngine;
//using System.Collections.Generic;

/// <summary>
/// This class Manages and helps the 'Cloner_GO.cs' Script to: create a group of similar GameObject with a CUSTOM UPDATE method, which is detailed down here.
/// I advice you to add as many Variable-Attributes (down here) as Different Behaviours (i.e.: different kinds of GameObject...) you have in the Scene.
/// 
/// NOTE:
/// *** This class has the ONLY standard Update() Method in the whole Project.
/// </summary>
public class UpdateManagerCustom : MonoBehaviour 
{

    /// <summary>
    /// Description of what this Script does.
    /// </summary>
    [Tooltip("This class Manages and helps the 'Cloner_GO.cs' Script to: create a group of similar GameObject with a CUSTOM UPDATE method, which is detailed down here. \n I advice you to add as many Variable-Attributes (down here) as Different Behaviours (i.e.: different kinds of GameObject...) you have in the Scene. \nNOTE:\n*** This class has the ONLY standard Update() Method in the whole Project.")]
    public string _whatDoesThisClassDoes = "This class Manages and helps the 'Cloner_GO.cs' Script to: create a group of similar GameObject with a CUSTOM UPDATE method, which is detailed down here. \n I advice you to add as many Variable-Attributes (down here) as Different Behaviours (i.e.: different kinds of GameObject...) you have in the Scene. \nNOTE:\n*** This class has the ONLY standard Update() Method in the whole Project.";


    #region GameObjects With Scripts to be Updated

    #region Robots
    /// <summary>
    /// Script that creates an ARRAY[] of all GameObjects to UPDATE. 
    /// You MUST access this class to get to the GameObject[]'s array to execute the UpdateMe() Method.
    /// </summary>
    public Cloner_GO _myCloner_GO;

    /// <summary>
    /// Scripts (Components) that have the UpdateMe() Method.
    /// </summary>    
    private MyRobotBehaviour[] _myManagedUpdateBehaviorList;         //Before using 'inheritance' it was: private ManagedUpdateBehavior[] _myManagedUpdateBehaviorList;

    #endregion Robots

    //And other kinds of GameObject's Behaviours HERE......

    #endregion GameObjects and Scripts to be Updated



    private void Start () 
	{
        // Initialize the var which stores the Component that has the CUSTOM UPDATE BEHAVIOUR.
        //
        if (this._myCloner_GO != null)
        {

            // Get the elements of the array....: put their Script Component inside this variable: _myManagedUpdateBehaviorList
            //
            if ((this._myCloner_GO._myCreatedGOArray != null) && (this._myCloner_GO._myCreatedGOArray.Length > 0) && (this._myCloner_GO._myCreatedGOArray[0] != null))
            {

                // 1- Create new array
                //
                this._myManagedUpdateBehaviorList = new MyRobotBehaviour[this._myCloner_GO._totalOfGameObjectsToCreate];


                // Go through the Loop and Get the Sript, & pass it out to the variable
                //
                for (int i = 0; i < this._myCloner_GO._totalOfGameObjectsToCreate; i++)
                {
                    this._myManagedUpdateBehaviorList[i] = this._myCloner_GO._myCreatedGOArray[i].GetComponent<MyRobotBehaviour>(); ;

                }//End for
                
            }//End if ((this._myCloner_GO._myCreatedGOArray != null) && (this._myCl......

        }//End if (this._myCloner_GO != null)

    }//End private void Start ()


    /// <summary>
    /// This IS the ONLY Update() Method in the whole Project.
    /// </summary>
    private void Update ()
    {
        // OPTIMUM
        //
        for (int i = 0; i < this._myCloner_GO._totalOfGameObjectsToCreate; i++)
        {
            this._myManagedUpdateBehaviorList[i].UpdateMe();

        }//End for

        // You may add some other For-Loops, similar to the one above: for other GameObjects/Behaviours..........
        //..........

    }//End private void Update ()
}
