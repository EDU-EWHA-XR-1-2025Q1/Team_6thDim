using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heeseo_Item_Controller : MonoBehaviour
{
    public GameObject PickController;
    
    void OnMouseDown()
    {
        print($"{gameObject.name} clicked");
        PickController.GetComponent<heeseo_Pick_Controller>().Add_Click(gameObject);
    }
}
