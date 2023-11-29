using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public int skillNum;
    public bool skillChange;

    public GameObject skill_1, skill_2, skill_3, skill_6;

    public Sprite vd, rf, mt, jp, pd, ff;
    private Image currentImage;

    void Start()
    {
        skillNum = 0;
        skillChange = false;
        skill_1.SetActive(false);
        skill_2.SetActive(false);
        skill_3.SetActive(false);
        skill_6.SetActive(false);
    }
    void Update()
    {
        
        // Debug.Log(skillNum);
        if (skillChange)
        {
            if (skillNum == 1)
            {
                skill_1.SetActive(true);
                skill_1.GetComponent<Image>().sprite = ff;
            }
            if (skillNum == 2)
            {
                skill_2.SetActive(true);
                skill_2.GetComponent<Image>().sprite = pd;
            }
            if (skillNum == 3)
            {
                skill_3.SetActive(true);
                skill_3.GetComponent<Image>().sprite = jp;
            }
            if (skillNum == 4)
            {
                skill_1.GetComponent<Image>().sprite = vd;
            }
            if (skillNum == 5)
            {
                skill_2.GetComponent<Image>().sprite = mt;
            }
            if (skillNum == 6)
            {
                skill_3.SetActive(false);
                skill_6.SetActive(true);
                skill_6.GetComponent<Image>().sprite = rf;
                skill_6.GetComponent<SkillAction>().coolReset = true;
            }


            
            skillChange = false;

        }
    }

}


    // // Skill - Sapo
    // public Image gaugeFillImage;
    // public Button actionButton;
    // public float fillSpeed = 0.1f;
    // public float maxFillAmount = 1.0f;

    // private float currentAmount = 0.0f;

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         // 충돌 발생 시 게이지를 조절
    //         currentAmount += fillSpeed;
    //         currentAmount = Mathf.Clamp(currentAmount, 0f, maxFillAmount);
    //         UpdateUI();

    //         // 게이지가 다 찼을 때 버튼 활성화
    //         if (currentAmount >= maxFillAmount)
    //         {
    //             actionButton.interactable = true;
    //         }
    //     }
    // }

    // void UpdateUI()
    // {
    //     // UI 게이지 업데이트
    //     gaugeFillImage.fillAmount = currentAmount / maxFillAmount;
    // }

    // public void OnButtonClick()
    // {
    //     // 버튼 클릭 시 호출되는 함수
    //     // 게이지 초기화 및 재충전 시작
    //     currentAmount = 0f;
    //     actionButton.interactable = false;
    //     UpdateUI();
    // }