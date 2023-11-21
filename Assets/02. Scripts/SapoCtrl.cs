using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SapoCtrl : MonoBehaviour
{
    public Image gaugeFillImage;
    public Button actionButton;
    public float fillSpeed = 0.1f;
    public float maxFillAmount = 1.0f;

    private float currentAmount = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 충돌 발생 시 게이지를 조절
            currentAmount += fillSpeed;
            currentAmount = Mathf.Clamp(currentAmount, 0f, maxFillAmount);
            UpdateUI();

            // 게이지가 다 찼을 때 버튼 활성화
            if (currentAmount >= maxFillAmount)
            {
                actionButton.interactable = true;
            }
        }
    }

    void UpdateUI()
    {
        // UI 게이지 업데이트
        gaugeFillImage.fillAmount = currentAmount / maxFillAmount;
    }

    public void OnButtonClick()
    {
        // 버튼 클릭 시 호출되는 함수
        // 게이지 초기화 및 재충전 시작
        currentAmount = 0f;
        actionButton.interactable = false;
        UpdateUI();
    }
} 