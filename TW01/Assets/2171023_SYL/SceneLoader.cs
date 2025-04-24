using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ �ʿ�

public class SceneChanger : MonoBehaviour
{

    public string sceneToLoad;

    public void LoadSceneByName()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("LoadScene ����: sceneToLoad�� ��� ����");
        }
    }
}
