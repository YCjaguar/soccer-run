using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScreen : MonoBehaviour
{
    public Animator playerAnim;
    public Animator ballAnim;
    private Vector2 startTouchPosition; 
    private Vector2 endTouchPosition;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition =  Input.GetTouch(0).position;

            if(endTouchPosition.x < startTouchPosition.x)
            {
                LeftMove();
            }
            if(endTouchPosition.x > startTouchPosition.x)
            {
                RightMove();
            }
        }
    }

    private void LeftMove()
    {
        playerAnim.SetBool("isLeft", true);
        ballAnim.SetBool("isLeft", true);
    }
    private void RightMove()
    {
        playerAnim.SetBool("isLeft", false);
        ballAnim.SetBool("isLeft", false);
    }
}
