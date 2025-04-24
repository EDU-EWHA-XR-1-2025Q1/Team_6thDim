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
        if (Input.GetMouseButtonDown(0)) // Ŭ��
        {
            if (pickedObject == null)
            {
                TryPick(); // ���� �� ������� ����
            }
            else
            {
                DropObject(); // ��� ������ ����
            }
        }

        if (pickedObject != null)
        {
            FollowCameraFront(); // �� �տ� �������
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
