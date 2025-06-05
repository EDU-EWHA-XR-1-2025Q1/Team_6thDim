using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    [SerializeField] private string sceneName;  // Inspector에서 씬 이름 지정

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
