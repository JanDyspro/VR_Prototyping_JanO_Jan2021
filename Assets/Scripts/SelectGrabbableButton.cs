using System.Collections.Generic;
using BNG;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectGrabbableButton : MonoBehaviour
{
    
    [SerializeField] private GrabButton initialGrabButton = GrabButton.Grip;
    
    //------------------------------------------------------------------------------------------------------------------
    
    public static SelectGrabbableButton Instance;
    private Grabbable[] grabbables;
    
    private void Awake()
    {
        Instance = this;
        grabbables = FindObjectsOfTypeAll<Grabbable>().ToArray();
        Debug.Log(grabbables.Length);
        SetGrabbable(initialGrabButton);
    }

    /// <summary>
    /// Use this to set the button.
    /// </summary>
    /// <param name="button"></param>
    public static void SetGrabbable(GrabButton button)
    {
        foreach (var grabbable in Instance.grabbables)
        {
            grabbable.GrabButton = button;
        }
    }


    private static List<T> FindObjectsOfTypeAll<T>()
    {
        var results = new List<T>();
        SceneManager.GetActiveScene().GetRootGameObjects();

        foreach (var parent in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            var addThis = parent.GetComponentsInChildren<T>(true);
            results.AddRange(addThis);
        }
        return results;
    }
}
