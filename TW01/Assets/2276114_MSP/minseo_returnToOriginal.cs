using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToOriginalScene : MonoBehaviour
{
    public string originalSceneName = "Original_Scene";

    public void ReturnToOriginal()
    {
        Debug.Log("씬 전환 함수 호출됨!"); // 이 줄 추가
        if (!string.IsNullOrEmpty(originalSceneName))
        {
            SceneManager.LoadScene(originalSceneName);
        }
        else
        {
            Debug.LogWarning("오리지널 씬 이름이 설정되지 않았습니다.");
        }
    }

}
