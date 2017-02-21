using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        float rand = Random.Range(0,10);

        if (rand<= 5)
        {
            Debug.Log("shoot right");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(50,20));
        }
        else
        {
            Debug.Log("shoot left");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-50, -20));
        }
    }
	
	// Update is called once per frame
	void OnTriggerEnter2D() {
        
            Debug.Log("hit sides");
        
	}
}
