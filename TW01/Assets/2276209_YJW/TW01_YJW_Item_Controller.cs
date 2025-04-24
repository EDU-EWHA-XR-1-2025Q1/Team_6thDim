using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_YJW_Item_Controller : MonoBehaviour
{
    public GameObject PickController;

    void OnMouseDown()
    {
        print($"{gameObject.name} clicked");
        PickController.GetComponent<TW01_YJW_Pick_Controller>().Add_Click(gameObject);
    }
}
