using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JH_Load_Scene : MonoBehaviour
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
