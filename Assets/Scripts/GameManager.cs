using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PoolManager pool;
    //public Player player;
    
    void Update()
    {
        instance = this;
    }
    
    public void GameOver()
    {
        Debug.Log("����");
    }
}
