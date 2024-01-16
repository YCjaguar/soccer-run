using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StopBtn : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject continuedBtn;
    public GameObject LoadMenuBtn;

    // Start is called before the first frame update
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        continuedBtn.SetActive(true);
        LoadMenuBtn.SetActive(true);
        Time.timeScale = 0f; // 시간을 멈춥니다.
    }

    // 게임을 계속 진행 상태로 만듭니다.
    public void ResumeGame()
    {
        continuedBtn.SetActive(false);
        LoadMenuBtn.SetActive(false);
        Time.timeScale = 1f; // 시간을 원래대로 돌립니다.
    }

    // 메인 메뉴로 돌아갑니다. 메인 메뉴 씬의 이름을 정확하게 적어야 합니다.
    public void LoadMenu()
    {
        Time.timeScale = 1f; // 메인 메뉴로 돌아가기 전에 시간을 원래대로 돌립니다.
        SceneManager.LoadScene("StartUI"); // 여기에 메인 메뉴 씬의 이름을 적습니다.
    }
}
