using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Panel;
    public TextMeshProUGUI Text_GameResult;

    private static GameManager _instance;
    public PoolManager pool;
    //public Player player;

    void Update()
    {
        _instance = this;
    }
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }
    
    public void GameOver()
    {
        Debug.Log("게임오버");
        int score = (int) FindObjectOfType<Score>().GetScore();
        Panel.SetActive(true);
        Text_GameResult.text = "GameScore : " + score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene("New Scene");
    }
}
