// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.EventSystems;

// public class JoystickCtrl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
// {
//     public VariableJoystick joy;
//     public float speed;

//     public RectTransform joystickBackground; // 조이스틱 배경 이미지
//     public RectTransform joystickHandle; // 조이스틱 핸들 이미지
//     public float moveSpeed = 5f; // 캐릭터 이동 속도

//     private Vector2 inputDirection;
//     private Rigidbody rigid;
//     private Animator anim;
//     private Vector3 moveVec;

//     private bool isJoystickMoving = false;

//     void Awake()
//     {
//         rigid = GetComponent<Rigidbody>();
//         anim = GetComponent<Animator>();
//     }

//     public void OnPointerDown(PointerEventData eventData)
//     {
//         isJoystickMoving = true;
//         UpdateJoystick(eventData);
//     }

//     public void OnPointerUp(PointerEventData eventData)
//     {
//         isJoystickMoving = false;
//         inputDirection = Vector2.zero;
//         joystickHandle.anchoredPosition = Vector2.zero; // 조이스틱 핸들 위치 초기화
//         rigid.velocity = Vector3.zero; // 캐릭터 이동 중지
//     }

//     public void OnDrag(PointerEventData eventData)
//     {
//         UpdateJoystick(eventData);
//     }

//     private void UpdateJoystick(PointerEventData eventData)
//     {
//         Vector2 pos = Vector2.zero;
//         RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickBackground, eventData.position, eventData.pressEventCamera, out pos);

//         pos.x = Mathf.Clamp(pos.x, -joystickBackground.sizeDelta.x / 2f, joystickBackground.sizeDelta.x / 2f);
//         pos.y = Mathf.Clamp(pos.y, -joystickBackground.sizeDelta.y / 2f, joystickBackground.sizeDelta.y / 2f);

//         joystickHandle.anchoredPosition = pos;

//         inputDirection = new Vector2(pos.x / joystickBackground.sizeDelta.x, pos.y / joystickBackground.sizeDelta.y);
//     }

//     void FixedUpdate()
//     {
//         if (isJoystickMoving)
//         {
//             MoveCharacter();
//         }
//     }

//     private void MoveCharacter()
//     {
//         // 캐릭터를 이동시키는 로직
//         moveVec = new Vector3(inputDirection.x, 0, inputDirection.y) * speed * Time.deltaTime;
//         rigid.MovePosition(rigid.position + moveVec);

//         if (moveVec.sqrMagnitude != 0)
//         {
//             Quaternion dirQuat = Quaternion.LookRotation(moveVec);
//             Quaternion moveQuat = Quaternion.Slerp(rigid.rotation, dirQuat, 0.3f);
//             rigid.MoveRotation(moveQuat);
//         }

//         anim.SetFloat("Move", moveVec.sqrMagnitude);
//     }
// }