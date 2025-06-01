using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleImageClickHandler : MonoBehaviour
{
    public int pieceID;               // ∆€¡Ò ¡∂∞¢ π¯»£ (1~6)
    public string sceneToLoad;        // ø¨∞·µ» ∆€¡Ò æ¿ ¿Ã∏ß

    public void OnClickPuzzle()
    {
        // ∆€¡Ò¿ª æ∆¡˜ »πµÊ«œ¡ˆ æ æ“¿∏∏È ¿Ãµø
        if (PuzzleManager.Instance != null && !PuzzleManager.Instance.HasPiece(pieceID))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.Log("¿ÃπÃ »πµÊ«— ∆€¡Ò¿‘¥œ¥Ÿ.");
        }
    }
}
