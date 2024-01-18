using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillAnim : MonoBehaviour
{
    public Animator animator_player;
    public Animator animator_ball;
    // Start is called before the first frame update
    /*void Start()
    {
        Button btn = GetComponent<Button>();
        //btn.onClick.AddListener(ChangeTrigger);
    }*/

    // Update is called once per frame
    public void ChangePtTrigger()
    {
        animator_player.SetTrigger("isPt"); // Trigger 변경
        animator_ball.SetTrigger("isPt");
    }

    public void ChangeFfTrigger()
    {
        animator_player.SetTrigger("isFf"); // Trigger 변경
        animator_ball.SetTrigger("isFf");
    }
}
