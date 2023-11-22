using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    // Start is called before the first frame update
    public Material[] backgrounds;  // 배경 Material 배열
    public float changeInterval = 10.0f;  // 배경 변경 주기 (초)

    private Renderer backgroundRenderer;
    private int currentBackgroundIndex = 0;

    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();

        // 시작할 때 첫 번째 배경으로 설정
        backgroundRenderer.material = backgrounds[currentBackgroundIndex];

        // 일정 주기마다 배경 변경
        StartCoroutine(ChangeBackground());
    }

    IEnumerator ChangeBackground()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeInterval);

            // 다음 배경으로 변경
            currentBackgroundIndex = (currentBackgroundIndex + 1) % backgrounds.Length;
            backgroundRenderer.material = backgrounds[currentBackgroundIndex];
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
