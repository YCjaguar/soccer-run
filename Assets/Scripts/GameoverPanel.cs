using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverPanel : MonoBehaviour
{
    public static GameoverPanel instance;
    public TextMeshProUGUI Text_GameResult; 
    private GameObject score;

    private void Awake()
    {
        
        transform.gameObject.SetActive(false); 
        

    }

    public void Show()
    {
        float score = FindObjectOfType<Score>().GetScore(); 
        transform.gameObject.SetActive(true); 
        Text_GameResult.text = "GameScore : " + score.ToString(); 
                                                                     
    
    }
    
    public void OnClick_Retry() 
    {
        SceneManager.LoadScene("GameScene"); 
                                             
    }
        // Start is called before the first frame update
        void Start()
    {
        score = GameObject.Find("Score");
    }

    // Update is called once per frame
    public void ShowGameOver()
    {
       transform.gameObject.SetActive(true);
        
    }
}
