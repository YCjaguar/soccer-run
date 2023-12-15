using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverPanel : MonoBehaviour
{
    //public static GameoverPanel instance;
    //public TextMeshProUGUI Text_GameResult;
    public GameObject gameOverText;

    private void Awake()
    {
        
        gameObject.SetActive(false); 
        

    }

    public void ShowPanel()
    {
        Debug.Log("GameOver");
        //float score = FindObjectOfType<Score>().GetScore(); 
        gameObject.SetActive(true); 
        //Text_GameResult.text = "GameScore : " + score.ToString(); 
                                                                     
    
    }
    
    public void OnClick_Retry() 
    {
        SceneManager.LoadScene("GameScene"); 
                                             
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

}
