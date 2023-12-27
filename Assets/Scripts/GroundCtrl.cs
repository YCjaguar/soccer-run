using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCtrl : MonoBehaviour
{
    public Material[] backgrounds;  // ��� Material �迭
    public float changeInterval = 10.0f;  // ��� ���� �ֱ� (��)

    private Renderer backgroundRenderer;
    private int currentBackgroundIndex = 0;
    private int nextBackgroundIndex = 1; // add next background index 

    private float transitionTimer = 0.0f;

    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();

        backgroundRenderer.material = backgrounds[currentBackgroundIndex];

//        StartCoroutine(ChangeBackground());
    }

    /* IEnumerator ChangeBackground()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeInterval);

            // ���� ������� ����
            currentBackgroundIndex = (currentBackgroundIndex + 1) % backgrounds.Length;
            backgroundRenderer.material = backgrounds[currentBackgroundIndex];
        
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        transitionTimer += Time.deltaTime;

        // calculate the time bewteen the current background and the next one
        float t = transitionTimer / changeInterval;

        if(t > 1.0f)
        {
            transitionTimer = 0.0f;
            currentBackgroundIndex = (currentBackgroundIndex + 1)   % backgrounds.Length;
            nextBackgroundIndex = (nextBackgroundIndex + 1) % backgrounds.Length;
        }

        backgroundRenderer.material.Lerp(backgrounds[currentBackgroundIndex], backgrounds[nextBackgroundIndex], t);
    }
}
