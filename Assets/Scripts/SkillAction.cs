using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillAction : MonoBehaviour
{
    public float coolTime;
    public float currentTime;
    public bool coolReset;
    
    private Image currentImage;
    void Awake()
    {
        currentImage = GetComponent<Image>();
        currentTime = 0.0f;
        coolReset = false;

    }

    void Update()
    {
        if (coolReset) 
        {
            currentTime = 0.0f;
            coolReset = false;
        }

        if (currentTime<coolTime)
        {
            currentTime+=Time.deltaTime;
            currentImage.fillAmount = currentTime/coolTime;
        }
        
        //currentImage.fillAmount = 1f;
        
    }
}
