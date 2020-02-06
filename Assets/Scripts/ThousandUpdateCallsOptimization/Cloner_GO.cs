using UnityEngine;

/// <summary>
/// This class creates a group of similar GameObject with a CUSTOM UPDATE method, which is detailed down here.
/// It can be replaced or deleted (if you have all your GameObjects (with partucular independet behaviours) already create in the Scene: just add attributes of this class, to point to them)... It was made just in case you need a Script for creating a bunch of GameObjects; and to illustrate the Main Optimization Idea.
/// </summary>
public class Cloner_GO : MonoBehaviour 
{

    /// <summary>
    /// Description of what this Script does.
    /// </summary>
    [Tooltip("It creates a group of similar GameObject with a CUSTOM UPDATE method, which is detailed down here")]
    public string _whatDoesThisClassDoes = "It creates a group of similar GameObject with a CUSTOM UPDATE method, which is detailed down here";


    /// <summary>
    /// GameObject to copy or clone.
    /// </summary>
    public GameObject _originalGameObject;

    /// <summary>
    /// GameObject's List[] to be used in another class/script.
    /// </summary>
    //[HideInInspector]
    public GameObject[] _myCreatedGOArray;


    /// <summary>
    /// Number of GOs to create.
    /// </summary>
    public int _totalOfGameObjectsToCreate = 10;


    private void Awake () 
	{

        // 1- Find the Original GameObject, to Cone it, and add the 10000000 objects to:
        //
        if (this._originalGameObject != null)
        {

            // 1- Create an array for later usage/access:
            //
            this._myCreatedGOArray = new GameObject[this._totalOfGameObjectsToCreate];
            //
            // Add the First GO:
            //
            this._myCreatedGOArray[0] = this._originalGameObject;


            // 2- Create the 1000000000 GameObjects:
            //
            for (int i = 1; i < this._totalOfGameObjectsToCreate; i++)
            {

                // Instantiate the GO, and add it as a Child of the GameObject that has this Script as a Component:
                //
                this._myCreatedGOArray[ i ] = Instantiate(this._originalGameObject, this.transform);

            }//End for (int i = 0; i < this._totalOfGameObjectsToCreate; i++)


        }//End if (this._myFatherGameObject == null)
         //else
         //{
         //    // Otherwise: Don't do anything.
         //}//End else

    }//End private void Awake () 

}
