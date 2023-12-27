using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCtrl : MonoBehaviour
{
    public float posX;
    void Start()
    {
        posX = 0.0f;
    }

    void Update()
    {
        transform.position = new Vector3(posX, 0f, 0f);
    }

}
