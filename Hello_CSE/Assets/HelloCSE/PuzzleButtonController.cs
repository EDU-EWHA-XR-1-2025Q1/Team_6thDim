using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleButtonController : MonoBehaviour
{
    public GameObject nextPuzzleButton;

    void Start()
    {
        nextPuzzleButton.SetActive(false);  // 초기 비활성화
    }

    public void OnClickGetPuzzle()
    {
        nextPuzzleButton.SetActive(true);  // 버튼 활성화
    }
}
