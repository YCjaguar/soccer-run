using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScreen : MonoBehaviour
{
    public Animator anim;
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
        anim.SetBool("isLeft", true);
    }
    private void RightMove()
    {
        anim.SetBool("isLeft", false);
    }
}
