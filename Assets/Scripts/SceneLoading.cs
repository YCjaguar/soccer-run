using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{
    public Slider progressbar;
    public Text loadtext;
    private AsyncOperation operation;
    private float speed = 0.2f; // ������ �ӵ�

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return null;

        operation = SceneManager.LoadSceneAsync("Progress");
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            yield return null;

            if (progressbar != null && loadtext != null)
            {
                float targetProgress = Mathf.Clamp01(operation.progress / 0.9f);
                progressbar.value = Mathf.MoveTowards(progressbar.value, targetProgress, Time.deltaTime * speed);

                if (progressbar.value >= 1f)
                {
                    loadtext.text = "Loading Complete!"; // ����� �ؽ�Ʈ

                    // �ڵ����� GameScene���� ��ȯ
                    if (operation.progress >= 0.9f)
                    {
                        operation.allowSceneActivation = true;
                        SceneManager.LoadScene("GameScene");
                    }
                }
            }
        }
    }
}

