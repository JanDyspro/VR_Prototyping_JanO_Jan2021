using System.Collections;
using DG.Tweening;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private GameObject leftDoor = null;
    [SerializeField] private GameObject rightDoor = null;

    [SerializeField] private Vector3 targetLocationLeft;
    [SerializeField] private Vector3 targetLocationRight;

    [Range(1, 10), SerializeField] private float moveDuration = 1;
    
    public void OnButtonPress()
    {
        StartCoroutine(DoMove());
    }

    private IEnumerator DoMove()
    {
        Debug.Log("Button pressed");
        leftDoor.transform.DOMove(targetLocationLeft, moveDuration);
        
        yield return new WaitForSeconds(moveDuration);
        rightDoor.transform.DOMove(targetLocationRight, moveDuration);
    }
}
