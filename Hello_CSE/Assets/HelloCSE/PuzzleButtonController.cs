using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleButtonController : MonoBehaviour
{
    public GameObject nextPuzzleButton;
    public int pieceID; // 퍼즐 조각 번호를 인스펙터에서 지정


    void Start()
    {
        nextPuzzleButton.SetActive(false);  // 초기 비활성화
    }

    public void OnClickGetPuzzle()
    {
        nextPuzzleButton.SetActive(true);  // 버튼 활성화
        PuzzleManager.Instance.CollectPiece(pieceID);
    }
}
