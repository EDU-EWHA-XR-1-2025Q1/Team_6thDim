using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heeseo_Put_Controller : MonoBehaviour
{
    public GameObject TargetObjectToThrow;
    public Transform PlayerCamera;

    bool isInTheArea = false;
    public GameObject UI;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isInTheArea) 
        {
            int pickCounts = UI.GetComponent<heeseo_UI_Controller>().GetPickCounts();
            
            if (pickCounts > 0)
            {
                Throw(); 
                UI.GetComponent<heeseo_UI_Controller>().Decrease_PickCounts();
                GameObject.Find("Pick_Controller").GetComponent<heeseo_Pick_Controller>().DecreaseCounter();

            }
        }
    }
    
    void Throw()
    {
        Vector3 Pos = PlayerCamera.position + PlayerCamera.forward;

        // 복제할 클론의 랜덤한 rotation
        float randomAngleX = Random.value * 360f;
        float randomAngleY = Random.value * 360f;
        float randomAngleZ = Random.value * 360f;
        Quaternion randomRot = Quaternion.Euler(randomAngleX, randomAngleY, randomAngleZ);

        // 복제하기
        GameObject Clone = Instantiate(TargetObjectToThrow, Pos, randomRot);

        // 복제한 클론 설정 
        Clone.SetActive(true);
        Clone.GetComponent<Collider>().isTrigger = false;
        Clone.GetComponent<Rigidbody>().useGravity = true;

        // 던지기
        Clone.GetComponent<Rigidbody>().AddForce(PlayerCamera.forward * 600f);

        // 소멸시키기
        Destroy(Clone, 5);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.name == "FPSController") 
        {
            isInTheArea = true;
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.name == "FPSController") 
        {
            isInTheArea = false; 
        }
    }
}
