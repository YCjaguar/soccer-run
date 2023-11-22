using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Unity Scene�� ǥ���� �ؽ�Ʈ UI(Text)�� ����Ű�� ����
    int score;
    private float elapsedTime; //��� �ð��� ������ ����

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0f; // ���� �ð� �ʱ�ȭ
        UpdateScoreText();
        // text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; // ��� �ð� ����
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // ��� �ð��� �ؽ�Ʈ�� ��ȯ�Ͽ� UI�� ǥ��
        scoreText.text = "Score : " + Mathf.Round(elapsedTime).ToString();
    }
}
