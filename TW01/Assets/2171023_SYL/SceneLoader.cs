using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리에 필요

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
            Debug.LogWarning("LoadScene 실패: sceneToLoad가 비어 있음");
        }
    }
}
