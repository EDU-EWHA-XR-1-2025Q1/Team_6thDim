using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dana_Scene_Loader2 : MonoBehaviour
{

    // �� �̸��� �ν����Ϳ��� ������ �� �ֵ��� ����(public)
    public string sceneToLoad = "Dana_scene";

    // UI ��ư�� ����� �Լ�
    public void LoadOriginalScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }


}
