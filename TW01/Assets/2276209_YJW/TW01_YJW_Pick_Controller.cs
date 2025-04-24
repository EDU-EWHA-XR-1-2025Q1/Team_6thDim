using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_YJW_Pick_Controller : MonoBehaviour
{
    int clickCounter = 0;
    public GameObject UI;
    bool isInTheArea = false;

    public void Add_Click(GameObject Clone)
    {
        if (isInTheArea)
        {
            clickCounter++;
            print($"clickCount: {clickCounter}");
            Destroy(Clone);

            UI.GetComponent<TW01_YJW_UI_Controller>().Display_PickCounts(clickCounter);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = false;
        }
    }
}
