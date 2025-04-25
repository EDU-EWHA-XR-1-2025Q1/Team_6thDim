using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class minseo_Scene_Controller : MonoBehaviour
{

    public string sceneToLoad;

    public void LoadSceneByName()
    {

        Debug.Log("LoadSceneByName ȣ���!");  // �� �� �߰�
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            Debug.Log($"�� �ε� �õ�: {sceneToLoad}");
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("LoadScene ����: sceneToLoad�� ��� ����");
        }
    }

}
