using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public Transform[] spawnPoint;
    private float timer;

    void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();   
    }

    void Update()
    {
        timer+=Time.deltaTime;
        if (timer > 2f){
            timer = 0;
            Spawn();
        }        
    }

    private void Spawn()
    {
        GameObject item = GameManager.instance.pool.Get(UnityEngine.Random.Range(0,1));
        item.transform.position += spawnPoint[UnityEngine.Random.Range(1, spawnPoint.Length)].position;

        // GameObject enemy = GameManager.instance.pool.Get(UnityEngine.Random.Range(1,2));
        // enemy.transform.position += spawnPoint[UnityEngine.Random.Range(1, spawnPoint.Length)].position;
        
    }
}
