﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yelin_Item_Controller : MonoBehaviour
{
    public GameObject PickController;
    private void OnMouseDown()
    {
        PrintInfo();
        PickController.GetComponent<yelin_Pick_Controller>().Add_Click(gameObject); 
    }

    void PrintInfo()
    {
        print($"{gameObject.name}을/를 클릭했습니다.");
    }
}
