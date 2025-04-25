using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class minseo_Scene_Controller : MonoBehaviour
{

    public string sceneToLoad;

    public void LoadSceneByName()
    {

        Debug.Log("LoadSceneByName 호출됨!");  // 이 줄 추가
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            Debug.Log($"씬 로드 시도: {sceneToLoad}");
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("LoadScene 실패: sceneToLoad가 비어 있음");
        }
    }

}
