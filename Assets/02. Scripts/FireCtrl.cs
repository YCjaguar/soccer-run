using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public float speed = 3.0f;
    public Animator animator;
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            gameObject.SetActive(false);
            animator.SetTrigger("IsJumpFire");
        }
    }
}
