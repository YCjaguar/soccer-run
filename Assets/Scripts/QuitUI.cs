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
        // ���ο� ���� ��ư ����
        GameObject newButton = new GameObject("QuitButton");
        newButton.transform.parent = transform; // QuitUI ��ü�� �ڽ����� ����

        // RectTransform ����
        RectTransform rectTransform = newButton.AddComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(300.0f, 50.0f); // ũ�� ����

        // ��ġ ����
        rectTransform.position = new Vector3(Screen.width - 75f, Screen.height - 75f, 0f); // ������ ��ܿ� ��ġ�ϵ��� ����

        // ���� ��ư�� Text ������Ʈ �߰� �� ����
        Text buttonText = newButton.AddComponent<Text>();
        buttonText.text = "Quit"; // ���� ��ư�� ǥ�õ� �ؽ�Ʈ
        buttonText.alignment = TextAnchor.MiddleCenter; // �ؽ�Ʈ �߾� ����
        buttonText.font = Resources.GetBuiltinResource<Font>("Arial.ttf"); // ���� ��Ʈ ��� (Arial)
        buttonText.color = Color.black; // �ؽ�Ʈ ���� ����

        // ��ư�� ���� ������ �����ϴ� Button ������Ʈ �߰�
        Button buttonComponent = newButton.AddComponent<Button>();
        buttonComponent.onClick.AddListener(ExitGame); // Ŭ�� �̺�Ʈ �߰�
    }

    // ���� ���� �Լ�
    public void ExitGame()
    {
        Debug.Log("������ �����մϴ�."); // ���� ���� �޽����� �α׿� ���
        Application.Quit(); // ���� ����
    }
}