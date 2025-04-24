using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heeseo_Pick_Controller : MonoBehaviour
{
    int clickCounter = 0;

    public GameObject UI;

    bool isInThePickArea = false;

    public void Add_Click(GameObject Clone)
    {
        if(isInThePickArea)
        {
            clickCounter++;
            print($"clickCount : {clickCounter}");

            Destroy(Clone);
            UI.GetComponent<heeseo_UI_Controller>().Display_PickCounts(clickCounter);
        }
    }

    public void DecreaseCounter()
    {
        clickCounter--;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.name == "FPSController") 
        {
            isInThePickArea = true;
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.name == "FPSController") 
        {
            isInThePickArea = false; 
        }
    }
}