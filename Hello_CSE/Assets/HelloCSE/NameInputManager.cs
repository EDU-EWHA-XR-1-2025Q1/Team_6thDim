using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameInputManager : MonoBehaviour
{
    public Button nameButton;         // "000님" 버튼
    public TextMeshProUGUI nameText;  // 버튼 안에 있는 텍스트
    public GameObject inputFieldObj;  // InputField 오브젝트
    public TMP_InputField inputField; // InputField 컴포넌트

    void Start()
    {
        inputFieldObj.SetActive(false); // 시작할 때 입력창 꺼놓기

        // 버튼 클릭 시 입력창 열기
        nameButton.onClick.AddListener(OpenInputField);

        // 엔터(Submit) 시 이름 저장
        inputField.onEndEdit.AddListener(OnNameEntered);
    }

    void OpenInputField()
    {
        inputFieldObj.SetActive(true);   // 입력창 보이기
        inputField.ActivateInputField(); // 포커스 주기 (바로 타이핑 가능)
    }

    void OnNameEntered(string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            nameText.text = input + "님"; // 입력된 이름 + "님"
        }
        inputFieldObj.SetActive(false);   // 입력창 닫기
    }
}
