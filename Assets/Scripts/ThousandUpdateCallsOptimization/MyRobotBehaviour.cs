using UnityEngine;

/// <summary>
/// This is the derived class (whose base is 'ManagedUpdateBehavior').
/// Reimplement UpdateMe() here.
/// </summary>
public class MyRobotBehaviour : ManagedUpdateBehavior
{

    /// <summary>
    /// Description of what this Script does.
    /// </summary>
    [Tooltip("This is the derived class (whose base is 'ManagedUpdateBehavior').\n***It has a Behaviour to Update. Reimplement UpdateMe() here")]
    public string _whatDoesThisClassDoes = "This is the derived class (whose base is 'ManagedUpdateBehavior').\n***It has a Behaviour to Update. Reimplement UpdateMe() here";


    /// <summary>
    /// (Replace it with real variables for the UPDATE() method of the Game): It is an example of the necessary variables for the update Method behaviour of this gameobjects.
    /// </summary>
    [Tooltip("(Replace it with real variables for the UPDATE() method of the Game): It is an example of the necessary variables for the update Method behaviour of this gameobjects.")]
    [SerializeField]
    private int i;



    /// <summary>
    /// Update Method: Replace it with the behaviour you want.
    /// </summary>
	public override void UpdateMe() 
	{

        // Change this with your particular Behaviour:
        //
		i++;

	}//End Method
}
