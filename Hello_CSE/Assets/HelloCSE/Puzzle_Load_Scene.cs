using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle_Load_Scene : MonoBehaviour
{
    public void LoadHome()
    {
        SceneManager.LoadScene("Scene_Home");
    }
    public void LoadStatus()
    {
        SceneManager.LoadScene("Scene_Status");
    }
    public void LoadSetting()
    {
        SceneManager.LoadScene("Scene_OnBoarding");
    }
    public void LoadPuzzle2()
    {
        SceneManager.LoadScene("Puzzle02");
    }
    public void LoadPuzzle3()
    {
        SceneManager.LoadScene("Puzzle03");
    }
    public void LoadPuzzle4()
    {
        SceneManager.LoadScene("Puzzle04");
    }
    public void LoadPuzzle5()
    {
        SceneManager.LoadScene("Puzzle05");
    }
    public void LoadPuzzle6()
    {
        SceneManager.LoadScene("Puzzle06");
    }
}
