using UnityEngine;

public class PuzzleBoard : MonoBehaviour
{
    public GameObject[] puzzlePiecePrefabs;   // 퍼즐 조각 프리팹들
    public Transform[] slotPositions;         // 퍼즐 조각이 들어갈 위치

    void Start()
    {
        foreach (int id in PuzzleManager.Instance.GetCollectedPieces())
        {
            GameObject piece = Instantiate(puzzlePiecePrefabs[id]);
            piece.transform.position = slotPositions[id].position;
            piece.transform.rotation = slotPositions[id].rotation;
        }
    }
}
