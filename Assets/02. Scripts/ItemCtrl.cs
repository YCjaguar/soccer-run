using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCtrl : MonoBehaviour
{
    public float speed = 3.0f;
    public Button originalButton;
    public Button newButton;
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            gameObject.SetActive(false);
            originalButton.gameObject.SetActive(false);
            newButton.gameObject.SetActive(true);
        }
    }
}
