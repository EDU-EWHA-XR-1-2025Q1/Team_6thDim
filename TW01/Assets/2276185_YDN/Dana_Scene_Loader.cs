using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dana_Scene_Loader : MonoBehaviour
{
    
    // �� �̸��� �ν����Ϳ��� ������ �� �ֵ��� ����(public)
    public string sceneToLoad = "Original_Scene";

    // UI ��ư�� ����� �Լ�
    public void LoadOriginalScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }


}
