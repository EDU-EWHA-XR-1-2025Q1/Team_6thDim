using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PuzzleTargetHandler : MonoBehaviour
{
    public GameObject getPuzzleButton;

    void Start()
    {
        getPuzzleButton.SetActive(false);

        var observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        Debug.Log("?? Target Status: " + targetStatus.Status);

        if (targetStatus.Status == Status.TRACKED ||
            targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            Debug.Log("?이미지 인식성공");
            getPuzzleButton.SetActive(true);
        }
        else
        {
            getPuzzleButton.SetActive(false);
        }
    }
}
