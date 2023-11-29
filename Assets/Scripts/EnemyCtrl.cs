using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCtrl : MonoBehaviour
{
    public float speed = 3.0f;
    public GameObject skills;
    // public Button originalButton;
    // public Button newButton;

    void Start()
    {
        skills = GameObject.Find("Skills");
        
    }
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){

            GameOver();
            // gameObject.SetActive(false);
            // skills.GetComponent<SkillManager>().skillNum++;
            // skills.GetComponent<SkillManager>().skillChange = true;
            // // originalButton.gameObject.SetActive(false);
            // // newButton.gameObject.SetActive(true);
        }
    }
    public void GameOver()
    {
        //Debug.Log("GameOver");
        GameManager.Instance.GameOver();
      

    }
}
