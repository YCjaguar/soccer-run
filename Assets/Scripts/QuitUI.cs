using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitUI : MonoBehaviour
{
    public void Start()
    {
        CreateQuitButton();
    }

    public void CreateQuitButton()
    {
        // 새로운 종료 버튼 생성
        GameObject newButton = new GameObject("QuitButton");
        newButton.transform.parent = transform; // QuitUI 객체의 자식으로 설정

        // RectTransform 생성
        RectTransform rectTransform = newButton.AddComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(300.0f, 50.0f); // 크기 설정

        // 위치 설정
        rectTransform.position = new Vector3(Screen.width - 75f, Screen.height - 75f, 0f); // 오른쪽 상단에 위치하도록 설정

        // 종료 버튼에 Text 컴포넌트 추가 및 설정
        Text buttonText = newButton.AddComponent<Text>();
        buttonText.text = "Quit"; // 종료 버튼에 표시될 텍스트
        buttonText.alignment = TextAnchor.MiddleCenter; // 텍스트 중앙 정렬
        buttonText.font = Resources.GetBuiltinResource<Font>("Arial.ttf"); // 내장 폰트 사용 (Arial)
        buttonText.color = Color.black; // 텍스트 색상 설정

        // 버튼의 모양과 동작을 설정하는 Button 컴포넌트 추가
        Button buttonComponent = newButton.AddComponent<Button>();
        buttonComponent.onClick.AddListener(ExitGame); // 클릭 이벤트 추가
    }

    // 게임 종료 함수
    public void ExitGame()
    {
        Debug.Log("게임을 종료합니다."); // 게임 종료 메시지를 로그에 출력
        Application.Quit(); // 게임 종료
    }
}