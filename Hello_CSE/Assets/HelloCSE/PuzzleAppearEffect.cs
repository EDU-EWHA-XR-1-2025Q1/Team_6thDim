using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PuzzleAppearEffect : MonoBehaviour
{
    public float duration = 0.5f; // 등장 시간

    void OnEnable()
    {
        if (!gameObject.activeInHierarchy || !enabled)
            return;
        StartCoroutine(Appear());
    }

    IEnumerator Appear()
    {
        RectTransform tf = GetComponent<RectTransform>();
        Image img = GetComponent<Image>();

        if (tf == null || img == null)
            yield break;

        Vector3 startScale = Vector3.zero;
        Vector3 endScale = Vector3.one;

        Color startColor = img.color;
        startColor.a = 0f;
        Color endColor = img.color;
        endColor.a = 1f;

        float t = 0;
        tf.localScale = startScale;
        img.color = startColor;

        while (t < 1f)
        {
            t += Time.deltaTime / duration;
            tf.localScale = Vector3.Lerp(startScale, endScale, t);
            img.color = Color.Lerp(startColor, endColor, t);
            yield return null;
        }

        // 보정
        tf.localScale = endScale;
        img.color = endColor;
    }
}
