using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemySet : MonoBehaviour
{
    public float delay;
    public GameObject enemy;
    private GameObject[] enemyset = new GameObject[31];
    private int[,] enemyActive = new int[,] {    {0, 0, 0},  { 0,  5,  0}, 
                                                 {0, 0, 0},  { 0,  0, 12},
                                                 {0, 0, 0},  {16,  0, 18}, 
                                                 {0, 0, 0},  { 0, 23,  0},
                                                 {0, 0, 0},  {28,  5, 30}
                                                 
    };
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                enemyset[i*3+j] = Instantiate(enemy, new Vector3(2f*(j-2), 0f, 15f), Quaternion.Euler(0,180,0));
                enemyset[i*3+j].SetActive(false);
            }
        }
        
        StartCoroutine(enemyInit(delay, 0));
    }

    void Update()
    {
        
    }

    IEnumerator enemyInit(float delayTime, int caseNum)             
    {
        // Debug.Log("Time = "+ Time.time);
        if (caseNum < 10)
        {
            if (enemyActive[caseNum, 0] != 0)
            {
                enemyset[enemyActive[caseNum, 0]].SetActive(true);
            }
            if (enemyActive[caseNum, 1] != 0)
            {
                enemyset[enemyActive[caseNum, 1]].SetActive(true);
            }
            if (enemyActive[caseNum, 2] != 0)
            {
                enemyset[enemyActive[caseNum, 2]].SetActive(true);
            }
        }
        yield return new WaitForSeconds(delayTime);
        StartCoroutine(enemyInit(delay, caseNum+1));
    }
}
