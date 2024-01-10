using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour {
    
    [SerializeField]
    private float scrollSpeedX = 0.1f;

    [SerializeField]
    private float scrollSpeedY = 0.1f;
    
	void Start () {
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", Vector2.zero);
	}
	
	// Update is called once per frame
	void Update () {
		 var x = Mathf.Repeat(Time.time * scrollSpeedX, 1);
        var y = Mathf.Repeat(Time.time * scrollSpeedY, 1);

        var offset = new Vector2(x, y);
        
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
}
