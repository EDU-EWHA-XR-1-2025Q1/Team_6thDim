using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dana_Scene_Loader : MonoBehaviour
{
    
    // 씬 이름을 인스펙터에서 설정할 수 있도록 공개(public)
    public string sceneToLoad = "Original_Scene";

    // UI 버튼에 연결될 함수
    public void LoadOriginalScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }


}
