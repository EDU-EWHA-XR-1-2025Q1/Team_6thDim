using UnityEngine;

public class PickManager : MonoBehaviour
{
    private Camera cam;
    private GameObject pickedObject = null;
    public float maxDistance = 3f;

    public Vector3 holdOffset = new Vector3(0f, -0.2f, 2f);
    public float followSpeed = 10f;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 클릭
        {
            if (pickedObject == null)
            {
                TryPick(); // 아직 안 들었으면 집기
            }
            else
            {
                DropObject(); // 들고 있으면 놓기
            }
        }

        if (pickedObject != null)
        {
            FollowCameraFront(); // 손 앞에 따라오게
        }
    }

    void TryPick()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            if (hit.collider.CompareTag("Pickable"))
            {
                pickedObject = hit.collider.gameObject;
                pickedObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }

    void DropObject()
    {
        pickedObject.GetComponent<Rigidbody>().isKinematic = false;
        pickedObject = null;
    }

    void FollowCameraFront()
    {
        Vector3 targetPos = cam.transform.position + cam.transform.rotation * holdOffset;
        pickedObject.transform.position = Vector3.Lerp(pickedObject.transform.position, targetPos, Time.deltaTime * followSpeed);
    }
}
