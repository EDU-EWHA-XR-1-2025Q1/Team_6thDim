using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleCollectButton : MonoBehaviour
{
    public int pieceID;                     // »πµÊ«“ ∆€¡Ò ID
    public string returnSceneName = "Scene_Status";  // µπæ∆∞• ∆€¡Ò∆« æ¿ ¿Ã∏ß

    public void OnClickCollect()
    {
        PuzzleManager.Instance.CollectPiece(pieceID);  // ∆€¡Ò ¿˙¿Â
        SceneManager.LoadScene(returnSceneName);       // ∆€¡Ò∆« æ¿¿∏∑Œ ¿Ãµø
    }
}

