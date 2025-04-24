using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yelin_Pick_Controller : MonoBehaviour
{
    int clickCounter = 0;   
    public GameObject UI;   

    public void Add_Click(GameObject Clone)
    {
        clickCounter++;
        print($"{clickCounter} 개의 클론을 클릭했습니다.");
        Destroy(Clone);

        UI.GetComponent<yelin_UI_Controller>().Display_PickCounts(clickCounter);
    }
}
