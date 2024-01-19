using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }
    public TextMeshProUGUI scoreText; 
    public float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0f; 
        UpdateScoreText();
        // text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; 
        UpdateScoreText();
        
    }
    public float GetScore()
    {
        return elapsedTime;
    }
    void UpdateScoreText()
    {
        scoreText.text = "Score : " + Mathf.Round(elapsedTime).ToString();
    }
}