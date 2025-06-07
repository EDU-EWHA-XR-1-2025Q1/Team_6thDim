using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameInputManager : MonoBehaviour
{
    public Button nameButton;
    public TextMeshProUGUI nameText;
    public GameObject inputFieldObj;
    public TMP_InputField inputField;

    private const string playerNameKey = "PlayerName";

    void Start()
    {
        inputFieldObj.SetActive(false);
        nameButton.onClick.AddListener(OpenInputField);
        inputField.onEndEdit.AddListener(OnNameEntered);

        // 저장된 이름이 있으면 UI에 표시
        string savedName = PlayerPrefs.GetString(playerNameKey, "");
        if (!string.IsNullOrEmpty(savedName))
        {
            nameText.text = savedName + "님";
        }
    }

    void OpenInputField()
    {
        inputFieldObj.SetActive(true);
        inputField.ActivateInputField();
    }

    void OnNameEntered(string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            nameText.text = input + "님";
            PlayerPrefs.SetString(playerNameKey, input);
            PlayerPrefs.Save(); // 저장을 디스크에 즉시 반영
        }
        inputFieldObj.SetActive(false);
    }
    void OnApplicationQuit()
    {
#if UNITY_EDITOR
        PlayerPrefs.DeleteKey("PlayerName");  // 저장된 이름 삭제
        PlayerPrefs.Save();                   // 즉시 반영
#endif
    }

}
