using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToOriginalScene : MonoBehaviour
{
    public string originalSceneName = "Original_Scene";

    public void ReturnToOriginal()
    {
        Debug.Log("�� ��ȯ �Լ� ȣ���!"); // �� �� �߰�
        if (!string.IsNullOrEmpty(originalSceneName))
        {
            SceneManager.LoadScene(originalSceneName);
        }
        else
        {
            Debug.LogWarning("�������� �� �̸��� �������� �ʾҽ��ϴ�.");
        }
    }

}
