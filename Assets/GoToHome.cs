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
        // "HomeScene"�� Ȩ ȭ���� �� �̸�����, ���� �� �̸����� ��ü�ؾ� �մϴ�.
        SceneManager.LoadScene("StartUI");
    }
}
