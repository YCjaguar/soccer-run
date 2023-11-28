using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCtrl : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemy")
        {
            // Enemy 와 충돌했을 때 GameOver 화면을 활성화
            GameoverPanel.instance.ShowGameOver();
        }
    }
}
