using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager Instance;

    private HashSet<int> collectedPieces = new HashSet<int>();
    public int PuzzleCount => collectedPieces.Count;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public int LastCollectedPieceID { get; private set; } = -1;

    public void CollectPiece(int id)
    {
        collectedPieces.Add(id);
        Debug.Log("∆€¡Ò ¡∂∞¢ »πµÊ: " + id);
        LastCollectedPieceID = id;
    }

    public bool HasPiece(int id)
    {
        return collectedPieces.Contains(id);
    }

    public IEnumerable<int> GetCollectedPieces()
    {
        return collectedPieces;
    }
    public void ClearHighlight()
    {
        LastCollectedPieceID = -1;
    }

}
