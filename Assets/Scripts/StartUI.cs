using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    // public GameObject background;
    public GameObject startBtn;
    
    void Start()
    {
        // background.GetComponent<RectTransform>().position = new Vector3(Screen.width/2f, Screen.height/2f, 0.0f);
        // background.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);
        startBtn.GetComponent<RectTransform>().position = new Vector3(Screen.width/2f, Screen.height/2f-Screen.height/3f, 0.0f);
        startBtn.GetComponent<RectTransform>().sizeDelta = new Vector2(300.0f, 50.0f);
    }

    void Update()
    {
        
    }

    public void StartBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
}
