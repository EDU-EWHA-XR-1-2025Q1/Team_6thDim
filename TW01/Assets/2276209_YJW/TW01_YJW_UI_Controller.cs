using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TW01_YJW_UI_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;
    public TMP_Text PutCounts;

    public void Display_PickCounts(int count)
    {
        PickCounts.text = count.ToString();
    }

    public void Decrease_PickCounts()
    {
        int lastPickCount = int.Parse(PickCounts.text);
        int currentPickCount = lastPickCount - 1;
        PickCounts.text = currentPickCount.ToString();
    }

    public int GetPickCounts()
    {
        int pickCounts = int.Parse(PickCounts.text);
        return pickCounts;
    }

    public void Display_PutCounts()
    {
        int lastPupCount = int.Parse(PutCounts.text);
        int currentPutCount = lastPupCount + 1;
        PutCounts.text = currentPutCount.ToString();
    }
}
