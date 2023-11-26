// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.EventSystems;

// public class MainUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
// {
//     // 버튼 타입 설정
//     public enum ButtonType
//     {
//         New,
//         Continue,
//         Setting,
//         Sound,
//         Back,
//         Quit
//     }

//     public ButtonType currentType;
//     public Transform buttonScale;
//     Vector3 defaultScale;
//     public CanvasGroup mainGroup;
//     public CanvasGroup optionGroup;
//     bool isSound = true; // 초기값 설정

//     private void Start()
//     {
//         defaultScale = buttonScale.localScale;
//     }

//     public void OnBtnClick()
//     {
//         switch (currentType)
//         {
//             case ButtonType.New:
//                 SceneLoader.LoadSceneHandle("Play", 0);
//                 break;
//             case ButtonType.Continue:
//                 SceneLoader.LoadSceneHandle("Play", 1);
//                 break;
//             case ButtonType.Setting:
//                 CanvasGroupOn(optionGroup);
//                 CanvasGroupOff(mainGroup);
//                 break;
//             case ButtonType.Sound:
//                 if (isSound)
//                 {
//                     isSound = false;
//                     Debug.Log("Sound Off");
//                 }
//                 else
//                 {
//                     isSound = true;
//                     Debug.Log("Sound On");
//                 }
//                 break;
//             case ButtonType.Back:
//                 CanvasGroupOn(mainGroup);
//                 CanvasGroupOff(optionGroup);
//                 break;
//             case ButtonType.Quit:
//                 Application.Quit();
//                 Debug.Log("앱종료");
//                 break;
//         }
//     }

//     public void CanvasGroupOn(CanvasGroup cg)
//     {
//         cg.alpha = 1;
//         cg.interactable = true;
//         cg.blocksRaycasts = true;
//     }

//     public void CanvasGroupOff(CanvasGroup cg)
//     {
//         cg.alpha = 0;
//         cg.interactable = false;
//         cg.blocksRaycasts = false;
//     }

//     public void OnPointerEnter(PointerEventData eventData)
//     {
//         buttonScale.localScale = defaultScale * 1.2f;
//     }

//     public void OnPointerExit(PointerEventData eventData)
//     {
//         buttonScale.localScale = defaultScale;
//     }
// }