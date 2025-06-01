using UnityEngine;
using TMPro;

public class PuzzleStatusHandler : MonoBehaviour
{
    public GameObject[] puzzleImages;   // Puzzle00 ~ Puzzle06
    public GameObject[] puzzleButtons;  // Button00 ~ Button06
    public TextMeshProUGUI countText;

    void Start()
    {
        int count = 0;
        int highlightID = PuzzleManager.Instance.LastCollectedPieceID;

        for (int i = 1; i <= 6; i++)
        {
            bool has = PuzzleManager.Instance.HasPiece(i);

            if (has)
            {
                puzzleImages[i].SetActive(true);
                puzzleButtons[i].SetActive(false);
                count++;
                if (i == highlightID)
                {
                    var fx = puzzleImages[i].GetComponent<PuzzleAppearEffect>();
                    if (fx != null)
                        fx.enabled = true;
                }
            }
            else
            {
                puzzleImages[i].SetActive(false);
                puzzleButtons[i].SetActive(true);
            }
        }

        if (countText != null)
        {
            countText.text = count.ToString();
        }

        
        PuzzleManager.Instance.ClearHighlight();
    }
}

