using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heeseo_Scene_Controller : MonoBehaviour
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
            Debug.LogWarning("LoadScene 실패: sceneToLoad가 비어 있음");
        }
    }
}
