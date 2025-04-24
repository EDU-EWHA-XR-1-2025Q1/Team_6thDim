using UnityEngine;
using UnityEngine.SceneManagement;

public class minseo_loadScene : MonoBehaviour
{
    public string mySceneName = "minseo_scene"; 
    public void LoadMine()
    {
        if (!string.IsNullOrEmpty(mySceneName))
        {
            SceneManager.LoadScene(mySceneName);
        }
        else
        {
            Debug.LogWarning("내 씬 이름이 비어 있습니다.");
        }
    }
}
