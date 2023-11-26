using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverPanel : MonoBehaviour
{
    public TextMeshProUGUI Text_GameResult; //������ ����� ǥ������ Text UI
    private GameObject score;

    private void Awake()
    {
        
            transform.gameObject.SetActive(false); // ������ ���۵Ǹ� GameOver �˾� â�� ������ �ʵ��� �Ѵ�.
        

    }

    public void Show()
    {
        float score = FindObjectOfType<Score>().GetScore(); // ScoreText�� ���� ���� ��ϵ� ������ �ҷ��´�.
        transform.gameObject.SetActive(true); // GameOver �˾� â�� ȭ�鿡 ǥ�� ��Ŵ
        Text_GameResult.text = "GameScore : " + score.ToString(); // �˾��� ���� â�� ���� ������ ǥ���Ѵ�.
                                                                      // \n �̶�� ���ڴ�! '�ٹٲ�' ��! GameSet�̶�� ���� ������ ���� ����
    
    }
    
    public void OnClick_Retry() // '�絵��' ��ư�� Ŭ���ϸ� ȣ�� �Ǿ��� �Լ�
    {
        SceneManager.LoadScene("GameScene"); // SceneManager�� LoadScene �Լ��� ����Ͽ�! ���� �� 'GameScene'�� �ٽ� �ҷ������� ��Ų��.
                                             // ���� ���� �ٽ� �ҷ����� ������ ����� �ȴ�.
    }
        // Start is called before the first frame update
        void Start()
    {
        score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (score.GetComponent<Score>().elapsedTime > 3.0f)
        {
            gameObject.SetActive(true);
        }
    }
}
