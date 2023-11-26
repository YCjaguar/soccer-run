using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCtrl : MonoBehaviour
{
    public Material[] backgrounds;  // ��� Material �迭
    public float changeInterval = 10.0f;  // ��� ���� �ֱ� (��)

    private Renderer backgroundRenderer;
    private int currentBackgroundIndex = 0;

    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();

        // ������ �� ù ��° ������� ����
        backgroundRenderer.material = backgrounds[currentBackgroundIndex];

        // ���� �ֱ⸶�� ��� ����
        StartCoroutine(ChangeBackground());
    }

    IEnumerator ChangeBackground()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeInterval);

            // ���� ������� ����
            currentBackgroundIndex = (currentBackgroundIndex + 1) % backgrounds.Length;
            backgroundRenderer.material = backgrounds[currentBackgroundIndex];
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
