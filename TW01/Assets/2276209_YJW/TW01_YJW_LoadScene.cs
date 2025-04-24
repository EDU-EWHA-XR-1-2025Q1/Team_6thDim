using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TW01_YJW_LoadScene : MonoBehaviour
{
    public string sceneToLoad;

    public void OnClick_LoadScene()
    {
        print("aa");
        SceneManager.LoadScene(sceneToLoad);
    }
}

