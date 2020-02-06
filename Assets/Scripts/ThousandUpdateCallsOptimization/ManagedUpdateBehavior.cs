using UnityEngine;

/// <summary>
/// This class has the particular Update Method. You should have as many different classes or implementations: as different Behaviours (i.e.: Update() Methods) in GameObjects: Cars, Robots - Behaviours...
/// You could derive this class and Override the 'UpdateMe' Method.
/// </summary>
public class ManagedUpdateBehavior : MonoBehaviour 
{

    ///// <summary>
    ///// Description of what this Script does.
    ///// </summary>
    //[Tooltip("Base class (you may derive it): It has the UPDATE METHOD for the created GameObjects.")]
    //public string _whatDoesThisClassDoes = "Base class (you may derive it): It has the UPDATE METHOD for the created GameObjects.";


    /// <summary>
    /// Update Method: Replace it with the behaviour you want.
    /// </summary>
	public virtual void UpdateMe() 
	{
	}//End Method
}
