using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Unity Scene에 표시할 텍스트 UI(Text)를 가리키는 변수
    int score;
    private float elapsedTime; //경과 시간을 저장할 변수

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0f; // 시작 시간 초기화
        UpdateScoreText();
        // text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; // 경과 시간 갱신
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // 경과 시간을 텍스트로 변환하여 UI에 표시
        scoreText.text = "Score : " + Mathf.Round(elapsedTime).ToString();
    }
}
