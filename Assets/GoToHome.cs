using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadHomeScene()
    {
        // "HomeScene"은 홈 화면의 씬 이름으로, 실제 씬 이름으로 교체해야 합니다.
        SceneManager.LoadScene("StartUI");
    }
}
