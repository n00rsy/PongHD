using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WallControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("i am wall");
    }

    // Update is called once per frame
    void OnCollisionEnter2D()
    {

        Debug.Log("hit sides trigger");
        SceneManager.LoadScene("End");
    }
}
