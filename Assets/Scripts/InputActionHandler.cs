using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputActionHandler : MonoBehaviour
{
    public Animator characterAnimator; // 캐릭터 Animator를 가리키는 변수

    // Start() 함수나 Awake() 함수 등에서 Animator 컴포넌트를 가져오는 코드
    void Start()
    {
        characterAnimator = GetComponent<Animator>(); // 예시로 캐릭터의 Animator를 가져오는 방법
    }

    public void ChangeToWalkAnimation()
    {
        characterAnimator.SetTrigger("IsWalk");
    }

    public void ChangeToJumpAnimation()
    {
        characterAnimator.SetTrigger("IsJump");
    }

    public void ChangeToFallAnimation()
    {
        characterAnimator.SetTrigger("IsFall");
    }
    public void ChangeToSprintAnimation()
    {
        characterAnimator.SetTrigger("IsSprint");
    }
    public void ChangeToStrafeAnimation()
    {
        characterAnimator.SetTrigger("IsStrafe");
    }
    public void ChangeToIdleAnimation()
    {
        characterAnimator.SetTrigger("IsIdle");
    }
    public void ChangeToExitAnimation()
    {
        characterAnimator.SetTrigger("IsExit");
    }
}
